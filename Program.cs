using H1W2D2RPG;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Character firstChar = new Character();

firstChar.CharacterClass = Character.GetCharacterClassRandomly();
firstChar.Stats.GetRolled();
firstChar.Stats.Dexterity = 1;


Console.WriteLine(firstChar.Name);