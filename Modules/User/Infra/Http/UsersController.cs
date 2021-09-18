using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp_template.src.modules.user.infra.ef.entities;
using csharp_template_v1._0;
using csharp_template_v1._0.Modules.User.Repositories;
using csharp_template_v1._0.src.shared.infra.ef.contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace csharp_template._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;
        private readonly ILogger<UsersController> logger;

        public UsersController(IUsersRepository usersRepository, ILogger<UsersController> logger)
        {
            this.usersRepository = usersRepository;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<object> Get()
        {

            return await usersRepository.FindById(2);

        }
    }
}
