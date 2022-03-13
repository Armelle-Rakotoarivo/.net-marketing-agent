using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBooks.Models
{
    public class Status
    {
        public string Message { get; set; }

        public Status(string message)
        {
            this.Message = message;
        }
    }
}
