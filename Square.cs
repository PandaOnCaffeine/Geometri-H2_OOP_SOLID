using System;

public class Square
{
	private double side;

	public Square(double side)
	{
		this.side = side;
	}
	public double Perimeter()
    {
		return side * 4;
    }
	public double Area()
    {
		return side * side;	
    }
}
