using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace С {
    class Program {
        static void Main(string[] args) {
            string MyConfigDB = "Database=employees;Data Source=localhost;User Id=root;Password=;";
            MySqlConnection conn = new MySqlConnection(MyConfigDB);
            conn.Open();
            string sql = "SELECT * FROM table1"; // Строка запроса
            MySqlScript script = new MySqlScript(conn, sql);
            int count = script.Execute();
            Console.WriteLine(("Executed " + count + " statement(s)."));
            Console.WriteLine("Delimiter: " + script.Delimiter);
        }
    }
}

            // List<MusicalInstrument> AllObjects = new List<MusicalInstrument>();

            // Guitar guitar = new Guitar(2500, "Metallic", "Acoustic", "G");
            // Violin violin = new Violin(1200, "Steel", "B");
            // Synthesizer synthesizer = new Synthesizer(4000, "Digital", "D");
            // Piano piano = new Piano(25000, 4, "C");

            // AllObjects.Add(guitar);
            // AllObjects.Add(violin);
            // AllObjects.Add(synthesizer);
            // AllObjects.Add(piano);

            // Console.WriteLine("Вывод до: ");
            
            // foreach (var obj in AllObjects)
            //     Console.WriteLine("Object " + obj.GetType().Name + " = " + obj.Cost + ", " + obj.ManufacturerCompany);

            // MusicalInstrument.SortInstrument(AllObjects);

            // Console.WriteLine("Вывод после: ");
            // foreach (var obj in AllObjects)
            //     Console.WriteLine("Object " + obj.GetType().Name + " = " + obj.Cost + ", " + obj.ManufacturerCompany);
            // Console.ReadLine();