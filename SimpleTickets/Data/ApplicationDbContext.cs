using Microsoft.EntityFrameworkCore;
using SimpleTickets.Models;

namespace SimpleTickets.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public DbSet<User> Users => Set<User>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Bord> Bords => Set<Bord>();
    public DbSet<BordColumn> BordColumns => Set<BordColumn>();
    public DbSet<Status> Statuses => Set<Status>();
    public DbSet<Ticket> Tickets => Set<Ticket>();
}
