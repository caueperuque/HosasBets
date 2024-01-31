using HosasBets.Matches.Models;
using Microsoft.EntityFrameworkCore;

namespace HosasBets.Matches.Repository;

public interface IHosasBetsContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Team> Teams { get; set;}
    public DbSet<Match> Matches { get; set;}
    public DbSet<Bet> Bets { get; set; }
    public int SaveChanges();
}