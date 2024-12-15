using MDCWordFinder;

class Program
{
    static void Main(string[] args)
    {
        // Crear la matriz de palabras
        var matrix = new List<string>
        {
            "abcdc",
            "fgwio",
            "chill",
            "pqnsd",
            "uvdxy"
        };

        // Crear el flujo de palabras a buscar
        var wordstream = new List<string>
        {
            "cold", "wind", "snow", "chill"
        };

        // Crear una instancia de WordFinder
        var wordFinder = new WordFinder(matrix);

        // Buscar palabras
        var foundWords = wordFinder.Find(wordstream);

        // Mostrar las palabras encontradas
        Console.WriteLine("Words found:");
        foreach (var word in foundWords)
        {
            Console.WriteLine(word);
        }
    }
}
