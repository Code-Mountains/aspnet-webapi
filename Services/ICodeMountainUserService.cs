using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Models;
using webApi.Models;

namespace webapi.Services
{
    public interface ICodeMountainUserService
    {
        Task<ResponseService<List<CodeMountainsUsers>>> getAllList();
        Task<ResponseService<CodeMountainsUsers>> getUserById(int id);

        Task<ResponseService<List<CodeMountainsUsers>>> AddNewUser(CodeMountainsUsers newUser);
        
    }
}