using System;

public class Violin : MusicalInstrument {

    private string typeOfCord;

    public Violin(int cost, string typeOfCord, string manufacturerCompany) : base (cost, manufacturerCompany) {
        this.typeOfCord = typeOfCord;
    }

    public string TypeOfCord {
        get {
            return typeOfCord;
        }
    }

}
