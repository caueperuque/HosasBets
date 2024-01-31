using HosasBets.DTO;

namespace HosasBets.Repository;

public interface ITeamRepository
{
    IEnumerable<TeamDTOResponse> Get();    
}