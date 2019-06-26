using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.nmv.Main
{
    public class MyOwnException : Exception
    {
        private string message;
        public string Message { get; set; }

        public MyOwnException(string message)
            :base(message)
        {
            this.Message = message;
        }

        public MyOwnException()
        {
            Message = "Мое новое исключение";
        }
    }
}
