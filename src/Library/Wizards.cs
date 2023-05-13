using System;

namespace  Characters
{
    public class Wizard
    {

        private int health = 100;

        public Wizard(string name, int health)
        {
            this.Name = name;
            this.health = health;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        // Para cuando tengamos una clase Personaje y poder usar Herencia
        /*
        public void Atacar(Personaje uno)
        {
            float var = (float)(uno.Vida - Math.Round((this.Daño)*(1-(uno.Defensa/500))));
            uno.Vida = var;
        }
        */

        public void Attack(Personaje personaje, ItemMagico libro)
        {
           // float var = (float)(Personaje.health - Math.Round((libro.Daño)*(1-(personaje.Defensa/500))));

        }



        public void Cure()
        {
            this.Health = 100;
        }

    }
    
}