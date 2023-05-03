using System;
namespace Library
{
    public class Elfo
    {
        public string Nombre {get; set;}
        public int CantidadVida {get; set; }

        public Elfo(string nombre, int vida) 
        {
            this.Nombre = nombre;
            this.CantidadVida = vida;
        }
        public void Curarse(int cantidad) 
        {
            CantidadVida += cantidad;
            Console.WriteLine($"Se ha curado a {Nombre}, su estado de vida actual es {CantidadVida}");
        }
        public void CurarPersonaje(int cantidad, Dwarves personaje)
        {
           personaje.Cure(cantidad);
           Console.WriteLine($"{Nombre}ha curado al personaje {personaje.Name}, y acutalmente su estado de vida es: {personaje.Life}");
        }
        public void LanzarFlecha(Dwarves personaje)
        {
            personaje.Life -= 20;
        }
        


    }
}