using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi.Models;

namespace webapi.Services
{
    public interface ICodeMountainUserService
    {
        List<CodeMountainsUsers> getAllList();
        CodeMountainsUsers getUserById(int id);

        List<CodeMountainsUsers> AddNewUser(CodeMountainsUsers newUser);
        
    }
}