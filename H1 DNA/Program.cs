using System;

namespace H1_DNA
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Just because the exercise used DNA as an example, I've made a DNA class containing a sequence string.
            // I've then compared two DNA objects' sequence strings to demonstrate the hamming calculators ability :)
            DNA dna1 = new DNA("GAGCCTACTAACGGGAT");
            DNA dna2 = new DNA("CATCGTAATGACGGCCT");

            HammingCalculator hc = new HammingCalculator();

            Console.WriteLine("Demo DNA sequence #1: " + dna1.Sequence + '\n' + "Demo DNA sequence #2: " + dna2.Sequence + '\n');
            Console.WriteLine("Hamming distance between the DNA sequences: " + hc.CalculateHammingDistance(dna1.Sequence, dna2.Sequence));

            Console.WriteLine("\nTry it yourself! Enter a string: \n");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter another sequence:\n");
            string input2 = Console.ReadLine();

            Console.WriteLine("Your sequence #1: " + input1 + '\n' + "Your sequence #2: " + input2 + '\n');
            Console.WriteLine("\nHamming distance between the strings: " + hc.CalculateHammingDistance(input1, input2));
        }
    }
}
