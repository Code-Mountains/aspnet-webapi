using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class ResponseService<T>
    {
        public T? Data { get; set; }
        public bool success {get;set;} = true;
        public string? Message {get; set;}
    }
}