namespace WizardsNinjasSamurai
{
    public class Wizard : Human
    {
        public Wizard (string name) : base(name){
            Health = 50;
            Intelligence = 25;
        }

        public override int Attack(Human target)
        {
            int damage = 5 * Intelligence;
            target.Health -= damage;
            Health += damage;
            return target.Health;
        }

        public int Heal(Human target) 
        {
            target.Health += 10 * Intelligence;
            return target.Health;
        }
    }
}
