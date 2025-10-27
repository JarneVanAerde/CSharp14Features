namespace WarehouseManager.Models;

public class Warehouse
{
    public int Id { get; set; }
    public required string Name { get; set; }

    // TODO: Use ++ compound operator to showcase that warehouse++ is valid in C# 14 and can increase the quantity by 1
    public int Quantity { get; set; }

    // TODO: Use the new field keyuword
    private string _Location;
    public required string Location
    {
        get => _Location;
        set => _Location = string.IsNullOrWhiteSpace(value) ? "Location Unknown" : value;
    }
}
