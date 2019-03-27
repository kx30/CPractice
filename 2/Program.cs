using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С {
    class Program {
        static void Main(string[] args) {
            List<MusicalInstrument> AllObjects = new List<MusicalInstrument>();

            Guitar guitar = new Guitar(2500, "Metallic", "Acoustic", "RKSI");
            Violin violin = new Violin(1200, "Steel", "RKSI");
            Synthesizer synthesizer = new Synthesizer(4000, "Digital", "RKSI");
            Piano piano = new Piano(25000, 4, "RKSI");

            AllObjects.Add(guitar);
            AllObjects.Add(violin);
            AllObjects.Add(synthesizer);
            AllObjects.Add(piano);

            MusicalInstrument.SortInstrument(AllObjects);

            foreach (var obj in AllObjects)
                Console.WriteLine("Object " + obj.GetType().Name + " = " + obj.Cost);
            Console.ReadKey();
        }
    }
}   
