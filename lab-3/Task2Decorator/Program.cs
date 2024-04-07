using Task2Decorator.HeroClasses;
using Task2Decorator.Items;

internal class Program
{
    private static void Main(string[] args)
    {
        var warrior = new Warrior("Aragorn");
        var mage = new Mage("Gandalf");
        var paladin = new Paladin("Uther");

        // Додаємо предмети до інвентаря
        warrior.Inventory.AddItem(new Armor());
        warrior.Inventory.AddItem(new Sword());
        mage.Inventory.AddItem(new Artifact());

        // Використання предметів інвентаря
        foreach (var item in warrior.Inventory.Items)
        {
            item.Use();
        }

        // Атака героїв
        warrior.Attack();
        mage.Attack();
        paladin.Attack();

    }
}