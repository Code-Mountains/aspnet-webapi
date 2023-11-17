using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi.Models;

namespace webapi.Services
{
    public class CodeMountainUserService : ICodeMountainUserService
    {
        private static List <CodeMountainsUsers> users = new List<CodeMountainsUsers>{
            new CodeMountainsUsers {Id = 1,FirstName ="Suyog", MiddleInitials ="B", LastName="Malla", Email="suyog.malla.office@gmail.com", PhoneNumber= "7203831470"},
            new CodeMountainsUsers {Id = 2,FirstName ="Kiran", LastName="Dangol", Email="kiran.dangol.office@gmail.com", PhoneNumber= "3186580709"},
            new CodeMountainsUsers {Id = 3,FirstName ="Vivek", LastName="Daruka", Email="Vivek.daruka.office@gmail.com", PhoneNumber= "3187894199"},
            new CodeMountainsUsers {Id =4, FirstName ="Aakash", LastName="Poudel", Email="aakash.poudel.office@gmail.com", PhoneNumber= "3182355829"},
        };
        public List<CodeMountainsUsers> AddNewUser(CodeMountainsUsers newUser)
        {
            users.Add(newUser);
            return users;
        }

        public List<CodeMountainsUsers> getAllList()
        {
            return users;
        }

        public CodeMountainsUsers getUserById(int id)
        {
            var user = users.FirstOrDefault(a => a.Id == id);
            if(user is not null){
                return user;
            } else {
                throw new Exception( $"User with id: {id} not found");
            }
            
        }
    }
}