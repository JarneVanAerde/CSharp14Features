using Microsoft.EntityFrameworkCore;
using WarehouseManager.Data;
using WarehouseManager.Extensions;
using WarehouseManager.Services;

var options = new DbContextOptionsBuilder<WarehouseContext>()
    .UseInMemoryDatabase("WarehouseDB")
    .Options;

using var dbContext = new WarehouseContext(options);
await WarehouseSeeder.Seed(dbContext);

var allWarehouses = await dbContext.Warehouses.ToListAsync();
allWarehouses.CleanWarehouses();
dbContext.SaveChanges();

var warehouseToUpdate = await dbContext.Warehouses.FindAsync(1);

Console.Write("Enter new quantity for Warehouse with Id 1: ");
var input = Console.ReadLine();

if (WarehouseQuantityParser.TryParseQuantity(input!, out var parsedQuantity))
{
    if (warehouseToUpdate != null)
    {
        warehouseToUpdate.Quantity = parsedQuantity;
    }
}

dbContext.SaveChanges();

foreach (var warehouse in dbContext.Warehouses)
{
    Console.WriteLine($"ID: {warehouse.Id}, Name: {warehouse.Name}, Quantity: {warehouse.Quantity}, Location: {warehouse.Location}");
}
