# WordFinder Sample Application

This is a sample application to demonstrate how to use the **MDCWordFinder** package to search for words in a grid of characters. The program initializes a word matrix, searches for specific words from a stream, and prints the words found.

## Prerequisites

- .NET SDK installed on your machine.
- A reference to the **MDCWordFinder** package.

## How It Works

1. A matrix of characters is created.
2. A list of words to search for is defined.
3. The **WordFinder** class is used to find matching words from the matrix.
4. The found words are displayed in the console.

## Code Example

Below is the sample code:

```csharp
using MDCWordFinder;

class Program
{
    static void Main(string[] args)
    {
        // Create the word matrix
        var matrix = new List<string>
        {
            "abcdc",
            "fgwio",
            "chill",
            "pqnsd",
            "uvdxy"
        };

        // Create the word stream to search
        var wordstream = new List<string>
        {
            "cold", "wind", "snow", "chill"
        };

        // Create an instance of WordFinder
        var wordFinder = new WordFinder(matrix);

        // Find words
        var foundWords = wordFinder.Find(wordstream);

        // Display the found words
        Console.WriteLine("Words found:");
        foreach (var word in foundWords)
        {
            Console.WriteLine(word);
        }
    }
}
```

## Output Example

If you run the program, it will display the words found in the matrix:

```
Words found:
chill
cold
wind
```

## Usage

1. Clone this repository or copy the code into a new .NET project.
2. Make sure the **MDCWordFinder** package is installed in your project.
3. Run the program and observe the output.

## About the MDCWordFinder Package

The **MDCWordFinder** package provides utilities for efficiently finding words in a matrix of characters. It is designed for performance and ease of use in applications that require word searching functionalities.

## License

This sample application is open-source and provided for demonstration purposes. Feel free to adapt or extend it as needed.
