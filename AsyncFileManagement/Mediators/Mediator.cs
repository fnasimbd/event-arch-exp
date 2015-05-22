using System;
using System.Collections.Generic;
using AsyncFileManagement.Handlers;

namespace AsyncFileManagement.Mediators
{
    public class Mediator
    {
        public delegate void HandleClientRequest(object obj, out string response);
        public delegate void HandleFileRequest(object obj, out string response);

        private List<object> _eventQueue = new List<object>();

        public List<object> EventQueue
        {
            get { return _eventQueue; }
        }

        private void FindHandler(object obj, out HandleFileRequest handler)
        {
            handler = null;

            var request = (UserRequest) obj;

            if (request.RequstType == "get")
            {
                var h = new GetValue();
                handler = h.GetValuehandler;
            }
            else if (request.RequstType == "set")
            {
                var h = new SetValue();
                handler = h.SetValueHandler;
            }
        }

        public void HandleUserRequest(object obj, out string response)
        {
            response = String.Empty;

            _eventQueue.Add(obj);

            HandleFileRequest fileRequestHandler;

            FindHandler(obj, out fileRequestHandler);

            fileRequestHandler(obj, out response);
        }

        public void HandleUpdateRequest()
        {
            
        }
    }
}
