using HosasBets.DTO;
using HosasBets.Models;

namespace HosasBets.Repository;

public interface IBetRepository
{
    BetDTOResponse Post(BetDTORequest betRequest, string email);
    BetDTOResponse Get(int BetId, string email);
}