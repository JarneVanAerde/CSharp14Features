using Microsoft.EntityFrameworkCore;
using WarehouseManager.Data;
using WarehouseManager.Models;

namespace WarehouseManager.Services;

public class WarehouseService
{
    private readonly WarehouseContext _context;

    public WarehouseService(WarehouseContext context)
    {
        _context = context;
    }

    public IEnumerable<Warehouse> GetAll() =>
        _context.Warehouses.AsNoTracking().OrderBy(i => i.Id);

    public async Task<Warehouse?> GetById(int id) =>
        await _context.Warehouses.FindAsync(id);

    public async Task Add(Warehouse warehouse)
    {
        await _context.Warehouses.AddAsync(warehouse);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(int id)
    {
        var warehouse = await _context.Warehouses.FindAsync(id);
        if (warehouse is null) return false;
        _context.Warehouses.Remove(warehouse);
        await _context.SaveChangesAsync();
        return true;
    }
}
