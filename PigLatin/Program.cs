using PigLatin;

Console.WriteLine("Pig Latin Translator");
Console.Write("Please enter a word: ");
string word = Console.ReadLine().ToLower();

Console.WriteLine(Translator.PigLatinize(word));