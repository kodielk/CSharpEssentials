using System;

public class Program
{
	public void Main()
	{
		Console.WriteLine("Valkommen");
		DoMath(10, 4);
		DoMath(20, 7);
		DoMath(30, 15);
		Compare(4,3);
		Compare(3,4);
		CheckPassword("KEKW");
	}

	public void DoMath(int value, int value2)
	{
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2){
		if(value > value2){
			Console.WriteLine("true, the first is greater");
		} else {
			Console.WriteLine("False. The second is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "KEKW") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");
		}
	}
}