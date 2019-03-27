using System;

public class Piano : MusicalInstrument {

    private int amountOfPedals;

    public Piano(int cost, int amountOfPedals, string manufacturerCompany) : base (cost, manufacturerCompany) {
        this.amountOfPedals = amountOfPedals;
    }

    public int AmountOfPedals {
        get {
            return amountOfPedals;
        }
    }

}
