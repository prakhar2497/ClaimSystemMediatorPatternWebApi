using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediatR;
using ClaimTrackingSystem.Data;
using ClaimTrackingSystem.Application.DTOs;
using ClaimTrackingSystem.Domain.Entities;
using ClaimTrackingSystem.Queries;
using AutoMapper;
using ClaimTrackingSystem.Commands;

namespace ClaimTrackingSystem.Controllers.UserManager
{
    [Route("api/user")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UsersController(ApplicationDBContext context, IMediator mediator, IMapper mapper)
        {
            _context = context;
            _mediator = mediator;
            _mapper = mapper;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUser()
        {
            var query = new GetAllUserQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(Guid id)
        {
            var query = new GetUserByIdQuery(id);
            var result = await _mediator.Send(query);
            return result;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<UserDTO> PutUser(Guid id, [FromBody]UserDTO user)
        {
            user.ID = id;
            var command = new UpdateUserCommand(id, user);
            var result = await _mediator.Send(command);
            return result;
        }

        // POST: api/Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody]CreateNewUserCommand userEntity)
        {
            var result = await _mediator.Send(userEntity);
            return CreatedAtAction("GetUser", new { id = result.ID },result);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> DeleteUser(Guid id)
        {
            var command = new DeleteUserCommand(id);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        private bool UserExists(Guid id)
        {
            return _context.User.Any(e => e.ID == id);
        }
    }
}
