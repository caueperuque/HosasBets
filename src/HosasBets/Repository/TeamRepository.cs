using HosasBets.DTO;

namespace HosasBets.Repository;

public class TeamRepository : ITeamRepository
{
    protected readonly IHosasBetsContext _context;
    public TeamRepository(IHosasBetsContext context)
    {
        _context = context;
    }

    public IEnumerable<TeamDTOResponse> Get()
    {
        return _context.Teams.Select(t => new TeamDTOResponse {
            TeamId = t.TeamId,
            TeamName = t.TeamName
        }).ToList();
    }
}