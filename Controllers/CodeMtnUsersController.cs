using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Services;
using webApi.Models;

namespace webApi.Controllers

{

    [ApiController]
    [Route("api/[controller]")]
    public class CodeMtnUsersController: ControllerBase
    {
        private readonly ICodeMountainUserService _codeMountainUserService;
        public CodeMtnUsersController(ICodeMountainUserService codeMountainUserService)
        {
            _codeMountainUserService = codeMountainUserService;
            
        }
        [HttpGet("GetAll")]
        public ActionResult<CodeMountainsUsers> getAllUsers(){
            return Ok(_codeMountainUserService.getAllList());
        }

        [HttpGet("{id}")]
        public ActionResult<CodeMountainsUsers> getUserById(int id){
            return Ok(_codeMountainUserService.getUserById(id));
        }

        [HttpPost]
        public ActionResult<List<CodeMountainsUsers>> addNewUser(CodeMountainsUsers newUser){
            return Ok(_codeMountainUserService.AddNewUser(newUser));
        }
    }
}