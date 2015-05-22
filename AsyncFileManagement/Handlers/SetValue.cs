using System;
using System.IO;
using System.Text;
using AsyncFileManagement.Mediators;

namespace AsyncFileManagement.Handlers
{
    class SetValue
    {
        public void SetValueHandler(object obj, out string response)
        {
            response = String.Empty;
            var values = (UserRequest) obj;
            var key = Encoding.ASCII.GetBytes(values.Key + ": ");
            var value = Encoding.ASCII.GetBytes(values.Value + "\n");

            using (FileStream fs = File.Create("file-01.txt"))
            {
                fs.Write(key, 0, key.Length);
                fs.Write(value, 0, value.Length);
            }
        }
    }
}
