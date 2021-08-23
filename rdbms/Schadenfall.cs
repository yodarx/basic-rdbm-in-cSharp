using System;

public enum State
{
    initialized,
    inProgress,
    auditied,
    archived,
    done,
}


public class Schadenfall
{
    int _claimNummer;
    int _insurance;
    int _insurant;
    String state;
    String description;

    public Schadenfall()
    {
        this._claimNummer = _claimNummer;
        this.state = State.initialized;
        this._insurance = _insurance;
        this._insurant = _insurant;
        this.description = description;
    }

    public void save(Schadenfall) { 
        //TODO save schadenfall to our file structure
    }

    public void change(State state) {
        this.state = state;
    }

    public void archive(State state)
    {
        this.state = State.archived;
        //TODO do more with archived stuff?
    }

    public void export(Schadenfall)
    {
        //TODO export a schadenfall to xml
    }
}
