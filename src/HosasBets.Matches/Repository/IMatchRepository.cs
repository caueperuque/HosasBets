using HosasBets.Matches.DTO;

namespace HosasBets.Matches.Repository;

public interface IMatchRepository
{
    IEnumerable<MatchDTOResponse> Get(bool MatchFinished);
}