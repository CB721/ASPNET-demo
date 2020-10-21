using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNETAngularDemo.API.Data;
using ASPNETAngularDemo.API.Entities;
using ASPNETAngularDemo.API.DTOs;

namespace ASPNETAngularDemo.API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> Register(RegisterDto registerDto)
        {
            // check to see if a user already exists in the db with the same username
            if (await UserExists(registerDto.UserName)) return BadRequest("Username is already taken.");
            // hashing algo to create password hash
            using var hmac = new HMACSHA512();
            var user = new AppUser
            {
                UserName = registerDto.UserName.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt = hmac.Key
            };
            // add user to db
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(existingUser => existingUser.UserName == username.ToLower());
        }
    }
}