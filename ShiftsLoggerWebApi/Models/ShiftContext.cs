using Microsoft.EntityFrameworkCore;

namespace ShiftsLoggerWebApi.Models;

public class ShiftContext(DbContextOptions<ShiftContext> options) : DbContext(options)
{
    public DbSet<Shift> Shifts { get; set; } = null!;
}
