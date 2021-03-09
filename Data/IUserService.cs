using WebApplication7.Model;

namespace WebApplication7.Data
{
    public interface IUserService
    {
        User ValidateUser(string UsernName, string Password);
    }
}