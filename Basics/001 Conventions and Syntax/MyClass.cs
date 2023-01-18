//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;

public class HeroFour{
    public Hero sova;
    public Weapon bow;

    public void Main()
    {
        sova = new Hero();
        bow = new Weapon();
		
		sova.arrowDmg*= bow.dmgMultiplier;
        Console.WriteLine(sova.heroName + "\nHealth is " + sova.sovaHealth + "\nCan shoot a shock arrow that does " + sova.baseDmg + " damage." + "\nHe has " + sova.ammoCount + " shock arrows per round.");
		Console.WriteLine("If the enhanced bow is equipped, the arrows will do " + sova.arrowDmg + " damage.");
    }

    
}
public class Hero{
	public string heroName = "Sova- Russias Technological Terror";
    public int sovaHealth = 100;
	public int baseDmg = 40;
    public float arrowDmg = 40.0f;
    public int ammoCount = 2;

}

public class Weapon {
    public float dmgMultiplier = 2.5f;
}