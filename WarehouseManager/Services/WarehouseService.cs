using Microsoft.EntityFrameworkCore;
using WarehouseManager.Data;
using WarehouseManager.Models;
using WarehouseManager.Extensions;

namespace WarehouseManager.Services;

public class WarehouseService(WarehouseContext context)
{
    private readonly WarehouseContext _context = context;

    public IEnumerable<Warehouse> GetAll() =>
        _context.Warehouses.AsNoTracking().OrderBy(i => i.Id);

    public Warehouse? GetById(int id) => _context.Warehouses.Find(id);

    public Warehouse Add(string name, int qty, string location)
    {
        var item = new Warehouse { Name = name, Quantity = qty, Location = location };
        _context.Warehouses.Add(item);
        _context.SaveChanges();
        return item;
    }

    public bool Update(int id, Action<Warehouse> mutate)
    {
        var item = _context.Warehouses.FirstOrDefault(x => x.Id == id);
        if (item is null) return false;

        mutate(item);
        _context.SaveChanges();
        return true;
    }

    public bool Delete(int id)
    {
        var item = _context.Warehouses.FirstOrDefault(x => x.Id == id);
        if (item is null) return false;
        _context.Warehouses.Remove(item);
        _context.SaveChanges();
        return true;
    }

    // C# 14: null-conditional assignment (assign only if receiver isn't null)
    public bool AssignLocationIfFound(int id, string newLocation)
    {
        var item = _context.Items.Find(id);
        item?.Location = newLocation;   // <- C# 14 null-conditional assignment
        if (item is null) return false;
        _context.SaveChanges();
        return true;
    }

    // C# 14: simple lambda parameters WITH modifiers (no types required)
    // We need a delegate type to use ref/out in lambdas.
    public delegate void RefAction<T>(ref T value);

    public int BumpQuantityByRef(int id, int delta)
    {
        var item = _context.Items.Find(id) ?? throw new InvalidOperationException("Not found");
        RefAction<int> bump = (ref var q) => q += delta; // <- modifier without type
        bump(ref item.Quantity);
        _context.SaveChanges();
        return item.Quantity;
    }

    // C# 14: nameof supports unbound generic types
    public string DiagnosticsSummary()
    {
        var parts = new[]
        {
            nameof(List<>),                // unbound generic in nameof
            nameof(Dictionary<,>),         // two-parameter unbound generic
            nameof(Warehouse)          // normal nameof
        };
        return string.Join(", ", parts);
    }

    // C# 14: implicit Span conversions (string -> ReadOnlySpan<char>, T[] -> Span<T>)
    public int CountLetters(string input)
    {
        ReadOnlySpan<char> s = input; // implicit conversion
        var count = 0;
        foreach (var c in s) if (char.IsLetter(c)) count++;
        return count;
    }
}
