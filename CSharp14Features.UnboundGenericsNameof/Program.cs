TryParse<int> parse = (string text, out int result) => Int32.TryParse(text, out result);

Console.WriteLine($"The only thing of interest here is the {nameof(TryParse<>)} delegate.");

delegate bool TryParse<T>(string text, out T result);