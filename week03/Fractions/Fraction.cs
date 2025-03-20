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

    // Properties
    // Setters
    public int GetTop() // Getter for _top
    {
        return _top;
    }

    public int GetBottom() // Getter for _bottom
    {
        return _bottom;
    }
}