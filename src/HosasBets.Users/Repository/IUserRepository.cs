using HosasBets.Users.DTO;
using HosasBets.Users.Models;

namespace HosasBets.Users.Repository;

public interface IUserRepository
{
    User Post(User user);
    User Login(AuthDTORequest login);
}