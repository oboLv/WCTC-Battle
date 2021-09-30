namespace WCTC_Battle.Models
{
    public class Enemy
    {
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }

        public Enemy()
        {
            Armor = new Armor();
            Weapon = new Weapon();
        }
    }
}