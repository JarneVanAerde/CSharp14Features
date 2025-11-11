namespace WarehouseManager.Services;

public static class WarehouseQuantityParser
{
    delegate bool TryParse<T>(string text, out T result);

    public static bool TryParseQuantity(string input, out int quantity)
    {
        TryParse<int> parse = (string text, out int result) =>
        {
            text = text.Trim();
            return int.TryParse(text, out result);
        };

        return parse(input, out quantity);
    }
}
