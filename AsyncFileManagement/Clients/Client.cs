using System;
using AsyncFileManagement.Mediators;

namespace AsyncFileManagement.Clients
{
    class Client
    {
        private UserRequest _request = new UserRequest()
        {
            RequstType = "set",
            Key = "version",
            Value = "1.0.1"
        };

        public void RequestSet()
        {
            string response = String.Empty;
            var mediator = new Mediator();

            mediator.HandleUserRequest(_request, out response);
        }
    }
}
