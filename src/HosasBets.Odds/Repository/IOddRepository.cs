using HosasBets.Odds.Models;

namespace HosasBets.Odds.Repository;

public interface IOddRepository
{
    Match Patch(int MatchId, int TeamId, string BetValue);
}