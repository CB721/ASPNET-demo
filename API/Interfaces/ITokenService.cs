using ASPNETAngularDemo.API.Entities;

namespace ASPNETAngularDemo.API.Interfaces
{
    // standard to prefix interfaces with 'I'
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}