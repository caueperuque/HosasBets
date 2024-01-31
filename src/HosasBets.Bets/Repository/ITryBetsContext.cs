using HosasBets.Bets.Models;
using Microsoft.EntityFrameworkCore;

namespace HosasBets.Bets.Repository;

public interface IHosasBetsContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Team> Teams { get; set;}
    public DbSet<Match> Matches { get; set;}
    public DbSet<Bet> Bets { get; set; }
    public int SaveChanges();
}