using System;

public class Guitar : MusicalInstrument {

    private string typeOfCord;
    private string typeOfGuitar;

    public Guitar(int cost, string typeOfCord, string typeOfGuitar, string manufacturerCompany) 
        : base (cost, manufacturerCompany) {
        this.typeOfCord = typeOfCord;
        this.typeOfGuitar = typeOfGuitar;
    }

    public string TypeOfCord {
        get {
            return typeOfCord;
        }
    }

    public string TypeOfGuitar {
        get {
            return typeOfGuitar;
        }
    }
}
