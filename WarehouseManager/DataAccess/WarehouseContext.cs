using Microsoft.EntityFrameworkCore;
using WarehouseManager.Models;

namespace WarehouseManager.Data;

public class WarehouseContext(DbContextOptions<WarehouseContext> options) : DbContext(options)
{
    public DbSet<Warehouse> Warehouses { get; set; }
}
