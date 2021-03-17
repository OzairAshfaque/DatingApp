using API.Entities;

namespace src.API.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(AppUser user);
    }
}