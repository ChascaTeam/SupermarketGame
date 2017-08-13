using System.Collections.Generic;


namespace Supermarket.Models.RandomGenerators
{
    public class NameGenerator : RNDGenerator
    {
        private List<string> namePool = new List<string>{ "Gosho","Pesho","Ivan","Petkan","Misho","Penka","Ana", "Ivanka","Petq", "Ivanina",
                                                         "Tanq","Ioana", "Martin","Vasko", "Konstantin", "Kristian", "Dimana", "Kalin", "Margarita", "Petranka" };

        public string GenerateName()
        {            
            var name = this.namePool[base.rnd(0,this.namePool.Count-1)];
            this.namePool.Remove(name);

            return name;
        }        
    }
}
