using Microsoft.EntityFrameworkCore;
using WarehouseManager.Data;
using WarehouseManager.Services;

var options = new DbContextOptionsBuilder<WarehouseContext>()
    .UseInMemoryDatabase("WarehouseDB")
    .Options;

using var dbContext = new WarehouseContext(options);
var warehouseService = new WarehouseService(dbContext);
await WarehouseSeeder.Seed(dbContext);

var warehouses = warehouseService.GetAll();
foreach (var warehouse in warehouses)
{
    Console.WriteLine($"ID: {warehouse.Id}, Name: {warehouse.Name}, Quantity: {warehouse.Quantity}, Location: {warehouse.Location}");
}
