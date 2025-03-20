using System;

public class Fraction
{
    private int _top;
    private int _bottom ;

    // Constructors
    public Fraction() // Default constructor initializes to 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) // Constructor initializes to _top/1
    {
        _bottom = 1;
    }

    public Fraction(int top, int bottom) // Constructor initializes to _top/_bottom
    {
        _top = top;
        _bottom = bottom;
    }
}