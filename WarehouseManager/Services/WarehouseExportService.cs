using WarehouseManager.Models;

namespace WarehouseManager.Services;

public class WarehouseExportService
{
    public static readonly string ListFormat = nameof(List<Warehouse>);
    public static readonly string HashSetFormat = nameof(HashSet<Warehouse>);

    public ICollection<Warehouse> ExportData(string format, ICollection<Warehouse> warehouses)
    {
        return format switch
        {
            nameof(List<Warehouse>) => ExportListData(warehouses),
            nameof(HashSet<Warehouse>) => ExportHashSetData(warehouses),
            _ => throw new NotSupportedException($"The format '{format}' is not supported for export.")
        };
    }

    private List<Warehouse> ExportListData(ICollection<Warehouse> warehouses) => warehouses.ToList();
    private HashSet<Warehouse> ExportHashSetData(ICollection<Warehouse> warehouses) => warehouses.ToHashSet();
}
