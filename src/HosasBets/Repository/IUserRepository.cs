using HosasBets.DTO;
using HosasBets.Models;

namespace HosasBets.Repository;

public interface IUserRepository
{
    User Post(User user);
    User Login(AuthDTORequest login);
}