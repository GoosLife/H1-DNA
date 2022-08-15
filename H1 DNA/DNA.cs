using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_DNA
{
    internal class DNA
    {
        private string sequence;
        
        /// <summary>
        /// Stores a DNA sequence in an array
        /// </summary>
        public string Sequence
        {
            get { return sequence; }
            private set { sequence = value; }
        }

        public DNA(string sequence)
        {
            Sequence = sequence;
        }
    }
}
