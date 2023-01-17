using System;

public class CharacterSelect

{
	public CharacterBase spacie;
	public Speed characterSpeed;

	
    public void Main()
    {
        spacie = new CharacterBase();
		characterSpeed = new Speed();
      
		
		Console.WriteLine(spacie.baseJabDmg);

    }
	
	
}
	

public class CharacterBase {
	public int baseJabDmg = 3;
	public int baseSpecialDmg = 12;
	public int baseDtiltDmg = 10;
}

public class Speed {
    public string foxSpeed = "fast";
    public string falcoSpeed = "medium";
}


