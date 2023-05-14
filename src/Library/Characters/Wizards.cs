using System;
using System.Collections.Generic;

namespace  RoleplayGame
{
    public class Wizard
    {

        public Wizard(string name, int life)
        {
            this.Name = name;
            this.QuantityLife = life;
        }

        public string Name { get; set; }
        public int QuantityLife { get; set; }
    
        private List<ItemMagic> Inventory; // Se le agregan los conocimientos de magia o items (Baston) que haya adquirido

        public void AddObjects(ItemMagic item)
        {
            this.Inventory.Add(item);
            if (item.DefenseValue > 0)
            {
                this.QuantityLife += item.DefenseValue;
            }
        }   

        public void Attack(ICharacter personaje)
        {
            int damage = 0;
            // float var = (float)(Personaje.health - Math.Round((libro.Daño)*(1-(personaje.Defensa/500))));
            //float var = (float)(personaje.QuantityLife - Math.Round(libro.Daño));
            foreach (ItemMagic items in Inventory)
            {
                damage += items.AttackValue;         // Sumo el valor de ataque de los objetos que tiene el mago.
            }

            if (damage == 0)      // Si el mago no tiene ningun item/conocimiento, el daño será 0.
            {
                damage = 10;    // Aca se le asigna un daño minimo para cuando no tiene conocimientos o items.
            }

            personaje.QuantityLife -= damage; // Le resta a la vida del personaje escogido, el daño.
            Console.WriteLine($"{personaje} ha recibido {damage} daño.");
        }

        /*
        public void Defense(ItemMagic libro)
        {
            return QuantityLife + libro.defenza;              
        }                                           

        */

        
    }
    
}