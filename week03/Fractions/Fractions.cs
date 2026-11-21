using System;

public class Fraction
{
    // Attributes are private, so other classes can't change them directly
    private int _top;
    private int _bottom;

    // Constructor 1: no parameters, sets the fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: one parameter for the top, bottom is 1 (so 5 becomes 5/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: parameters for both the top and the bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns the fraction in the form 3/4
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value, such as 0.75
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}