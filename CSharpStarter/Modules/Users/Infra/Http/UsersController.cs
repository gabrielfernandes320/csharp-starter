using CSharpStarter.Modules.Users.Infra.Ef.Entities;
using CSharpStarter.Modules.Users.Interfaces;
using CSharpStarter.Shared.Infra;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharpStarter.Modules.Users.Infra.Http
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ICreateUserService _createUserService = null;
        private readonly IUpdateUserService _updateUserService = null;
        private readonly IDeleteUserService _deleteUserService = null;
        private readonly IListUserService _listUserService = null;
        private readonly IShowUserService _showUserService = null;
        public UsersController(
            ICreateUserService createUserService,
            IUpdateUserService updateUserService,
            IDeleteUserService deleteUserService,
            IListUserService listUserService,
            IShowUserService showUserService)
        {
            _createUserService = createUserService;
            _updateUserService = updateUserService;
            _deleteUserService = deleteUserService;
            _listUserService = listUserService;
            _showUserService = showUserService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<object> GetAsync()
        {
                var users = await _listUserService.Execute(new { id = 1 });
                return users;   
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var user = await _showUserService.Execute(id);
            return Ok(user);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<object> PostAsync([FromBody] User user)
        {
            var createdUser = await _createUserService.Execute(user);
            return Ok(createdUser);

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<object> Put(int id, [FromBody] User user)
        {
            var updatedUser = await _updateUserService.Execute(id, user);
            return Ok(updatedUser);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            //try
            //{
                await _deleteUserService.Execute(id);
                return Ok();
            //}
            //catch (Exception ex)
            //{
            //    return NotFound(new {statusCode = 404, message = "Entity not found" });
            //}
        }
    }
}
