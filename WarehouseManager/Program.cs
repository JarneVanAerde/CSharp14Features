using Microsoft.EntityFrameworkCore;
using WarehouseManager.Data;
using WarehouseManager.Services;

var options = new DbContextOptionsBuilder<WarehouseContext>()
    .UseInMemoryDatabase("WarehouseDB")
    .Options;

using var dbContext = new WarehouseContext(options);
var warehouseService = new WarehouseService(dbContext);
await WarehouseSeeder.Seed(dbContext);

var warehouseToUpdate = await dbContext.Warehouses.FindAsync(1);
if (warehouseToUpdate != null)
{
    warehouseToUpdate.Quantity = 42;
}
dbContext.SaveChanges();


foreach (var warehouse in dbContext.Warehouses)
{
    Console.WriteLine($"ID: {warehouse.Id}, Name: {warehouse.Name}, Quantity: {warehouse.Quantity}, Location: {warehouse.Location}");
}
