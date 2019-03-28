using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С {
    class Program {
        static void Main(string[] args) {
            List<MusicalInstrument> AllObjects = new List<MusicalInstrument>();

            Guitar guitar = new Guitar(2500, "Metallic", "Acoustic", "G");
            Violin violin = new Violin(1200, "Steel", "B");
            Synthesizer synthesizer = new Synthesizer(4000, "Digital", "D");
            Piano piano = new Piano(25000, 4, "C");

            AllObjects.Add(guitar);
            AllObjects.Add(violin);
            AllObjects.Add(synthesizer);
            AllObjects.Add(piano);

            Console.WriteLine("Вывод до: ");
            
            foreach (var obj in AllObjects)
                Console.WriteLine("Object " + obj.GetType().Name + " = " + obj.Cost + ", " + obj.ManufacturerCompany);

            MusicalInstrument.SortInstrument(AllObjects);

            Console.WriteLine("Вывод после: ");
            foreach (var obj in AllObjects)
                Console.WriteLine("Object " + obj.GetType().Name + " = " + obj.Cost + ", " + obj.ManufacturerCompany);
        }
    }
}   
