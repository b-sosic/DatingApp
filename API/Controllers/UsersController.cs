using API.Data;
// using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using API.interfaces;
using System.Reflection.Metadata;
using AutoMapper;
using API.DTOs;
using System.Diagnostics.CodeAnalysis;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
      private readonly IUserRepository _userRepository;
      private readonly IMapper _mapper;
      public UsersController(IUserRepository userRepository, IMapper mapper)
      {
        _userRepository = userRepository;
        _mapper = mapper;
    }
   // [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
    {
       var users = await _userRepository.GetMembersAsync();
       
       return Ok(users);
 
        // return BadRequest();
    }
    [HttpGet("{username}")]
    public async Task<ActionResult<MemberDto>> GetUser(string username)
    {
        return await _userRepository.GetMemberAsync(username);

        

    }

}
}