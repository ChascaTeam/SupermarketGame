using System.Collections.Generic;

namespace Supermarket.Models.RandomGenerators
{
    public class NameGenerator : RNDGenerator
    {
        private List<string> vowels = new List<string> { "a", "o", "u", "e", "i", "y" };

        private List<string> consonants = new List<string> { "t", "r", "v", "p", "m", "n", "b", "z", "c", "g", "k", "l", "s", "d", "f" };

        public string GenerateName()
        {
            var name = this.consonants[base.Rnd(0, this.consonants.Count - 1)].ToUpper() +
                       this.vowels[base.Rnd(0, this.vowels.Count - 1)] +
                       this.consonants[base.Rnd(0, this.consonants.Count - 1)] + 
                       this.vowels[base.Rnd(0, this.vowels.Count - 1)] +
                       this.consonants[base.Rnd(0, this.consonants.Count - 1)];

            return name;
        }
    }
}
