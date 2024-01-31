using HosasBets.Matches.DTO;

namespace HosasBets.Matches.Repository;

public interface ITeamRepository
{
    IEnumerable<TeamDTOResponse> Get();    
}