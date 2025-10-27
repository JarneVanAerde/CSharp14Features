TryParse<int> parse = (text, out result) => Int32.TryParse(text, out result);

parse("123", out var parsedResult);
parsedResult++;
Console.WriteLine($"The parsed result + 1 is {parsedResult}");

delegate bool TryParse<T>(string text, out T result);