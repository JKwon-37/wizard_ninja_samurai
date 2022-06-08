namespace WizardsNinjasSamurai 
{
    class Ninja : Human
    {
        public Ninja (string name) : base(name){
            Name =name;
            Dexterity = 175;
        }

        public override int Attack (Human target)
        {
            int damage = 5 * Dexterity;
            target.Health -= damage;
            Random rand = new Random();
            if (rand.Next(1,6) == 1) {
                damage += 10;
            }
            return target.Health;
        }

        public int Steal (Human target) 
        {
            target.Health -= 5;
            Health += 5;
            return target.Health;
        }
    }
}
