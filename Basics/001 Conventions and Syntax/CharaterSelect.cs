using System;

public class CharacterSelect

{
	public CharacterProfile fox;
	public CharacterProfile falco;
	public CharacterProfile jigglypuff;	
	public Speed CharacterSpeed;

	
    public void Main()
    {
        fox = new CharacterProfile();
        falco = new CharacterProfile();
        jigglypuff = new CharacterProfile();

        Console.WriteLine("Starfox's poster child and the game's most busted character. Plays" + CharacterSpeed.foxSpeed + " and has a damage output of " + CharacterProfile.foxDamage);
    }
	
	
}
	

public class CharacterProfile {
	public int foxDamage = 20;
	public int falcoDamge = 30;
	public int puffDamage = 80;
}

public class Speed {
    public string foxSpeed = "fast";
    public string falcoSpeed = "medium";
    public string puffSpeed = "slow";
}

public class Damage {
    public int baseDamage = 20;
   
}
