using JWTAuthenticationAPI.Models;

namespace JWTAuthenticationAPI.Services
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}