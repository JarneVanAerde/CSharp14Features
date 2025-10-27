using WarehouseManager.Models;

namespace WarehouseManager.Extensions;

public static class WarehouseExtensions
{
    // TODO: convert this method to the new extension method syntax
    public static void CleanWarehouses(this IEnumerable<Warehouse> warehouses)
    {
        foreach (var warehouse in warehouses)
        {
            warehouse.Quantity = 0;
        }
    }

    // TODO: add an extension property called 'Total' that returns the total quantity of all warehouses

    // TODO: add a static extension property called 'Empty' that returns an empty list of warehouses

}
