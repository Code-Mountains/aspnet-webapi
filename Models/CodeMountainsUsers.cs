using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Models
{
    public class CodeMountainsUsers
    {
         public int Id {get;set;}
        public string? FirstName {get;set;} 
        public string? MiddleInitials {get;set;}
        public string? LastName {get;set;}
        public string? PhoneNumber {get;set;}
        public string? Email {get;set;}
    }
}