using WarehouseManager.Data;
using WarehouseManager.Models;

public static class WarehouseSeeder
{
    public static async Task Seed(WarehouseContext context)
    {
        await context.Warehouses.AddRangeAsync(new List<Warehouse>
        {
            new() { Name = "Wooden Pallets", Quantity = 150, Location = "A1" },
            new() { Name = "Steel Beams", Quantity = 75, Location = "B3" },
            new() { Name = "Paint Buckets", Quantity = 240, Location = "C2" },
            new() { Name = "Safety Helmets", Quantity = 90, Location = "D4" },
            new() { Name = "Packaging Tape", Quantity = 300, Location = "E1" }
        });

        await context.SaveChangesAsync();
    }
}