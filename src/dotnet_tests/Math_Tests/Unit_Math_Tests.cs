using System;
using Xunit;
using Library;

namespace Math_Tests
{
    public class Unit_Math_Tests
    {

	// Testuje Spocitanie
    [Theory]
	[InlineData(1,2,3)]
	[InlineData(-5,-4,-9)]
	[InlineData(-1,1,0)]
	[InlineData(0,5,5)]
	// Desatinne cisla
	[InlineData(1.05, 1.5, 2.55)] 
	[InlineData(0.5, -0.5, 0)]
	[InlineData(11.7, -5.3, 6.3999999999999995)]  // mozno neprejde kvoli nepresnosti pocitania PC
	[InlineData(-4.5, 2.3, -2.2)]
	[InlineData(0, 8.234, 8.234)]
    public void Add_Returns_Sum(double x, double y, double expected)
    {
	var TheClassToTest = new TheClassToTest();
	var sum = TheClassToTest.plus(x,y);

	Assert.Equal(expected, sum);
    }


	// Testuje Odpocitanie
	[Theory]
	[InlineData(5,2,3)]
	[InlineData(15,0,15)]
	[InlineData(0,15,-15)]
	[InlineData(-5,-7,2)]
	[InlineData(-1,1,-2)]
	[InlineData(1,-1,2)]
	// Desatinne cisla
	[InlineData(20.75, 5.25, 15.50)]
	[InlineData(0, 5.128, -5.128)]
	[InlineData(5.5, 0, 5.5)]
	[InlineData(78.89, 78.89, 0)]
	[InlineData(45.00045, -2.1, 47.10045)]
	[InlineData(-100.005, 5.002, -105.00699999999999)] // mozno neprejde kvoli nepresnosti pocitania PC
	public void Substract_Returns_Substraction_Value(double x, double y, double expected)
	{
		var sub = new TheClassToTest();
		var res = sub.minus(x,y);

		Assert.Equal(expected, res);
	}


	// Testuje Nasobenie
	[Theory]
	[InlineData(1,1,1)]
	[InlineData(5,0,0)]
	[InlineData(-5,6,-30)]
	[InlineData(6,-5,-30)]
	[InlineData(-8,-8,64)]
	// Desatinne cisla
	[InlineData(2.85, 1.2, 3.42)]
	[InlineData(0, 5.41, 0)]
	[InlineData(7.8, 0, 0)]
	[InlineData(-10.542, 4.235, -44.64537)]
	[InlineData(1.002, -6.0101, -6.022120200000001)] // mozno neprejde kvoli nepresnosti pocitania PC 
	public void Multiply_Returns_Multiplication_Value(double x, double y, double expected)
	{
		var mult = new TheClassToTest();
		var res = mult.mul(x,y);

		Assert.Equal(expected, res);
	}


	// Testuje Delenie
	[Theory]
	[InlineData(10,2,5)]
	[InlineData(0,5,0)]
	[InlineData(15,-3,-5)]
	[InlineData(-42,7,-6)]
	[InlineData(-120,-6,20)]
	// Desatinne cisla
	[InlineData(17.25, 1.5, 11.5)]
	[InlineData(24.111, 6.258, 3.8528283796740173)]
	[InlineData(0, 5.21, 0)]
	[InlineData(-12.8, 2.4,-5.333333333333334)]
	[InlineData(-15.9, -3, 5.3)]
	public void Devide_Returns_Division_Value(double x, double y, double expected)
	{
		var dev = new TheClassToTest();
		var res = dev.div(x,y);

		Assert.Equal(expected, res);
	}


	// Testuje delenie 0
	// Ak chces aby vratila funkcia 0
	// Mozes vymazat ak pouzijes try and catch
	[Theory]
	[InlineData(15, 0, 0)]
	[InlineData(-150, 0, 0)]
	[InlineData(9.578, 0, 0)]
	[InlineData(-78.95, 0, 0)]
	public void Devide_By_Zero(double x , double y, double expected)
	{
		var zero = new TheClassToTest();
		var res = zero.div(x,y);

		Assert.Equal(expected, res);
	}

	
	// Testuje Faktorial
	[Theory]
	[InlineData(1,1)]
	[InlineData(2,2)]
	[InlineData(3,6)]
	[InlineData(0,1)]
	[InlineData(10,3628800)]
	public void Factorial_Returns_Multiplication_Of_Its_All_Element_value(int x, int expected)
	{
		var fact = new TheClassToTest();
		var res = fact.fact(x);

		Assert.Equal(expected, res);
	}


	// Testuje Umocnenie
	[Theory]
	[InlineData(5,2,25)]
	[InlineData(2,3,8)]
	[InlineData(-3,3,-27)]
	[InlineData(12,10,61917364224)]
	[InlineData(5,0,1)]
	[InlineData(-5,0,1)]
	[InlineData(0,15,0)]
	// Desatinne cisla
	// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	// Nemusia prejst kvoli zaokruhlovaniu
	//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
	[InlineData(2.5, 2, 6.25)]
	[InlineData(5.78, 3, 193.10055200000002)]
	[InlineData(-4.12, 4, 288.13025536000004)]
	[InlineData(0, 12, 0)]
	[InlineData(5.2854, 0, 1)]
	[InlineData(5, 1, 5)]
	public void Power_Returns_Base_Raised_To_Exponent_Value(double zaklad, int exponent, double expected)
	{
		var pow = new TheClassToTest();
		var res = pow.exp(zaklad, exponent);

		Assert.Equal(expected, res);
	}


	// Testuje Umocnenie na n-tu
	[Theory]
	[InlineData(16,2, 4)]
	[InlineData(81, 2, 9)]
	[InlineData(15625, 6, 5)]
	[InlineData(196, 3,   5.80878573356370)]
	[InlineData(150, -5,  0.36709777158498)]
	[InlineData(1000, 4,  5.62341325190349)] 
	[InlineData(0, 8, 0)]
	[InlineData(9765625, 10, 5)]
	[InlineData(15.7, 3, 2.50399361701224)]
	[InlineData(0.08, 5, 0.60341763365451)]
	public void Root_Returns_Evoluted_value(double zaklad, double index, double expected)
	{
		var root = new TheClassToTest();
		var res = root.sqrt(zaklad, index);

		Assert.Equal(expected, res);
	}


	// Testuje Absolutnu hodnotu
	[Theory]
	[InlineData(-5, 5)]
	[InlineData(150, 150)]
	[InlineData(0, 0)]
	[InlineData(0.151, 0.151)]
	[InlineData(-5.784, 5.784)]
	[InlineData(-15987.75321, 15987.75321)]
	public void Abs_Returns_Absolut_Value_of_Given_Number(double x, double expected)
	{
		var abs = new TheClassToTest();
		var res = abs.abs(x);

		Assert.Equal(expected, res);
	} 

    }
}
