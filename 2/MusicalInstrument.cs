using System;
using System.Collections.Generic;

public class MusicalInstrument {

    private int cost;
    private string manufacturerCompany;
    private string color;


    public MusicalInstrument(int cost, string manufacturerCompany) {
        this.cost = cost;
        this.manufacturerCompany = manufacturerCompany;
    }

    public int CompareTo(MusicalInstrument o) {
            MusicalInstrument p = o as MusicalInstrument;
            if (p != null)
                return this.Cost.CompareTo(p.Cost);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

    public static List<MusicalInstrument> SortInstrument(List<MusicalInstrument> ms) {
        Console.WriteLine("\nВыберите 1 для сортировки по стоимости, 2 - для сортировки по производителю");
        int sortColumn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("sort column: " + sortColumn);
        if (sortColumn == 1) { 
            ms.Sort(delegate (MusicalInstrument i1, MusicalInstrument i2) {
                return i1.Cost.CompareTo(i2.Cost);
            });
        } else if (sortColumn == 2) {
            ms.Sort(delegate (MusicalInstrument i1, MusicalInstrument i2) {
                return i1.ManufacturerCompany.CompareTo(i2.ManufacturerCompany);
            });
        } else {
            Console.WriteLine("Error");
        }

        return ms;
    }

    public int Cost {
        get {
            return cost;
        }
    }

    public string ManufacturerCompany {
        get {
            return manufacturerCompany;
        }
    }

}