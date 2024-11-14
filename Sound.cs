using System;

abstract class Animals
{
    public string Navn { get; }

    protected Animals(string navn)
    {
        Navn = navn;
    }

    public abstract void MakeSound();
}
