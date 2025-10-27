namespace WarehouseManager.Models;

public class Warehouse
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public int Quantity { get; set; }

    private string _Location;
    public required string Location
    {
        get => _Location;
        set => _Location = string.IsNullOrWhiteSpace(value) ? "Location Unknown" : value;
    }
}
