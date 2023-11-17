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
        public async Task<ActionResult<ResponseService<CodeMountainsUsers>>> getAllUsers(){
            return Ok(await _codeMountainUserService.getAllList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseService<CodeMountainsUsers>>> getUserById(int id){
            return Ok(await _codeMountainUserService.getUserById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ResponseService<List<CodeMountainsUsers>>>> addNewUser(CodeMountainsUsers newUser){
            return Ok(await _codeMountainUserService.AddNewUser(newUser));
        }
    }
}