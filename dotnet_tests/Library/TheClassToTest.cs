using System;

namespace Library
{
    public class TheClassToTest
    {

	public double Add(double x, double y)
	{
		return x + y;
	}

	public double Substract(double x, double y)
	{
		return x - y;
	}

	public double Multiply(double x, double y)
	{
		return x * y;
	}

	public double Devide(double x, double y)
	{
		// Uprav si to len aby si vedel try/catch pre delenie 0
		try
		{
			double res = x/y;
		}
		catch (System.Exception)
		{
			Console.WriteLine("Chyba");
		}

		return x/y;
	}
	

	// Vracia Int
	// Faktorial z des.cisla neexistuje
	public int Factorial(int x)
	{
	// Dopln si implementaciu
		return 0;
	}


	// Vracia double
	// Zaklad moze byt double
	// Exponent musi byt cele cislo
    public double Power(double zaklad, int exponent)
	{
	// Dopln si implementaciu
		return 0;
	}


	// Vracia double
	// Zaklad moze byt double
	// Odmocnitel musi byt cele cislo
	public double Root(double zaklad, int index)
	{
	// Dopln si Implementaciu
		return 0;
	}

	
	// Vracia double
	// Vypocita absolutnu hodnotu z X

	public double Abs(double x)
	{
	// Dopln si implementaciu
		return 0;
	}

    }
}
