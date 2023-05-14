using System;

namespace  RoleplayGame
{
    public class Wizard
    {

        public int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
            //this.health = health;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        

        public void Attack(ICharacter personaje, ItemMagico libro)
        {
           // float var = (float)(Personaje.health - Math.Round((libro.Daño)*(1-(personaje.Defensa/500))));
            float var = (float)(personaje.Quantity - Math.Round((libro.Daño) - personaje.defense));
        }



        public void Cure()
        {
            this.Health = 100;
        }

    }
    
}