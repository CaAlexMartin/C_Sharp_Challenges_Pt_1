using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_36_Hero_Monster
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "King Alex";
            hero.Health = 100;
            hero.DamageMaximum = 50;
            hero.AttackBonus = false;

            Character Monster = new Character();
            Monster.Name = "Wicked Witch";
            Monster.Health = 75;
            Monster.DamageMaximum = 25;
            Monster.AttackBonus = false;

            int damage = hero.Attack();
            Monster.Defend(damage);

            damage = Monster.Attack();
            hero.Defend(damage);

            printStats(hero);
            printStats(Monster);

        }
        private void printStats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name {1} - Damage Maximum: {2} - AttackBonus: {3}</p>",
                character.Name,
                character.Health,
                character.DamageMaximum.ToString(),
                character.AttackBonus.ToString());
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(this.DamageMaximum);
            return damage;
        }
        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }


}