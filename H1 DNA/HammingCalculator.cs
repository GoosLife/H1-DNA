using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_DNA
{
    internal class HammingCalculator
    {
        public int CalculateHammingDistance(string first, string second)
        {
            int hammeringDistance = 0;
            int shortest = first.Length < second.Length ? first.Length : second.Length; // Find the shortest sequence
            int longest = first.Length > second.Length ? first.Length : second.Length; // Find the  longest sequence
            
            // I am assuming the comparison is supposed to start on the first index of the data - i.e., 
            // sentence1 = "This is an example" compared to
            // sentence2 = "is an exa ple"
            // would produce unexpected(?) results, unless we know that we're supposed to be starting at index 2 for string 1, and index 0 for string 2.
            // This program doesn't account for that.
            
            for (int i = 0; i < shortest; i++)
            {
                if (!(first[i] == second[i]))
                {
                    hammeringDistance++;
                }
            }

            // Add the amount of extra characters to the total hamming distance
            hammeringDistance += longest - shortest;

            return hammeringDistance;
        }
    }
}
