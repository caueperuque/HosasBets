using HosasBets.Bets.DTO;
using HosasBets.Bets.Models;

namespace HosasBets.Bets.Repository;

public interface IBetRepository
{
    BetDTOResponse Post(BetDTORequest betRequest, string email);
    BetDTOResponse Get(int BetId, string email);
}