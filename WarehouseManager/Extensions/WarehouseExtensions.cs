using WarehouseManager.Models;

namespace WarehouseManager.Extensions;

public static class WarehouseExtensions
{
    public static void CleanWarehouses(this IEnumerable<Warehouse> warehouses)
    {
        foreach (var warehouse in warehouses)
        {
            warehouse.Quantity = 0;
        }
    }
}
