using WarehouseManager.Models;

namespace WarehouseManager.Services;

// TODO: show off unbound generics by making this class generic
public class WarehouseExportService
{
    public static readonly List<string> SupportedFormats =
    [
        $"Supports {nameof(List<Warehouse>)} for all warehouses",
        $"Supports {nameof(HashSet<Warehouse>)} for unique warehouses",
    ];

    public ICollection<Warehouse> ExportData(string type, ICollection<Warehouse> warehouses)
    {
        return type switch
        {
            nameof(List<Warehouse>) => ExportListData(warehouses),
            nameof(HashSet<Warehouse>) => ExportHashSetData(warehouses),
            _ => throw new NotSupportedException($"The collection type '{type}' is not supported for export.")
        };
    }

    private List<Warehouse> ExportListData(ICollection<Warehouse> warehouses) => warehouses.ToList();
    private HashSet<Warehouse> ExportHashSetData(ICollection<Warehouse> warehouses) => warehouses.ToHashSet();
}
