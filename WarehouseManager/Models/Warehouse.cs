namespace WarehouseManager.Models;

public class Warehouse : Entity
{
    public required string Name { get; set; }

    public int Quantity { get; set; }

    private string _Location;
    public required string Location
    {
        get => _Location;
        set => _Location = string.IsNullOrWhiteSpace(value) ? "Location Unknown" : value;
    }
}
