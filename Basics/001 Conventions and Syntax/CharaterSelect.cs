using System;

public class CharacterSelect
{
	public Character fox;
	public Character falco;
	public Character jigglypuff;
	
    public void Main()
    {
        fox = new Character();
        falco = new Character();
        jigglypuff = new Character();
    }
	
}
	

public class Character {

}

public class Speed {
    public string foxSpeed = "fast";
    public string falcoSpeed = "medium";
    public string puffSpeed = "slow";
}

public class Damage {
    public int baseDamage = 20;
   
}

public class CharacterDamage {
	public int foxDamage = baseDamage/4;
	}
		