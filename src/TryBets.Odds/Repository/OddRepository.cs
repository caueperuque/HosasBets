using TryBets.Odds.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Globalization;

namespace TryBets.Odds.Repository;

public class OddRepository : IOddRepository
{
    protected readonly ITryBetsContext _context;
    public OddRepository(ITryBetsContext context)
    {
        _context = context;
    }

    public Match Patch(int MatchId, int TeamId, string BetValue)
    {
        var match = _context.Matches.FirstOrDefault(m => m.MatchId == MatchId);
        var BetValueConverted = BetValue.Replace(",", ".");
        var BetValueDecimal = decimal.Parse(BetValueConverted, CultureInfo.InvariantCulture);

        if (match!.MatchTeamAId != TeamId && match.MatchTeamBId != TeamId)
        {
            throw new Exception("Don't exist this TeamId in this match");
        }

        if (match.MatchTeamAId == TeamId)
        {
            match.MatchTeamAValue += BetValueDecimal;
        }
        else
        {
            match.MatchTeamBValue += BetValueDecimal;
        }

        _context.Matches.Update(match);
        _context.SaveChanges();

        return match;
    }
}