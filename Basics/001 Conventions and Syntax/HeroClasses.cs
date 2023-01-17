//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.attackSpeed = 8;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.attackSpeed = 10;

		heroThree.health = heroOne.health*2;
		heroThree.powerLevel = heroOne.powerLevel*2;
		heroThree.attackSpeed = 6;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.attackSpeed);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.attackSpeed);

		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);
		Console.WriteLine(heroThree.attackSpeed);

	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int attackSpeed;
}