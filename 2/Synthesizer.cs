using System;

public class Synthesizer : MusicalInstrument {

    private string typeOfSynthesizer;

    public Synthesizer(int cost, string typeOfSynthesizer, string manufacturerCompany) : base (cost, manufacturerCompany) {
        this.typeOfSynthesizer = typeOfSynthesizer;
    }

    public string TypeOfSynthesizer {
        get {
            return typeOfSynthesizer;
        }
    }

}
