using Microsoft.EntityFrameworkCore;
using System;
using WarehouseManager.Data;
using WarehouseManager.Services;
using WarehouseManager.Utils;

var options = new DbContextOptionsBuilder<WarehouseContext>()
    .UseInMemoryDatabase("WarehouseDB")
    .Options;

using var ctx = new WarehouseContext(options);
var svc = new WarehouseService(ctx);
var ui = new ConsoleUI(svc);

ui.Run();