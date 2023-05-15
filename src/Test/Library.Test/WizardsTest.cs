using NUnit.Framework;


namespace RoleplayGame
{
    public class WizardsTest
    {
        [Test]
        public void TestingWizards()
        {
            Wizard Wizard1 = new Wizard("Dr. Strange", 100);
            Wizard Wizard2 = new Wizard("Dr. Doom", 100);
            ItemMagic Object = ItemMagic("Libro", "El Poder del Fuego", 50, 0);  // Me da error. Dice que ItemMagic no es invocable. No se si me da problema el Namespace en el archivo de ItemMagic
            Wizard1.AddObjects(Object);
            Wizard1.Attack(Wizard2);

            Assert.AreEqual(50, Wizard2.QuantityLife);
        }
    }
}

/*
        public void  MagoTesteado()
        {
        Mago newmago = new Mago("Merlin");
        Mago secondmago = new Mago("Oscurus");
        Assert.AreEqual(60, newmago.Vida );
        newmago.Atacar(newmago);
        Assert.AreEqual(-34, newmago.Vida );

        LibroDeMagia libroDeMagia = new LibroDeMagia();
        newmago.EquiparMagia(libroDeMagia);
        Assert.AreEqual(180, newmago.Daño);

        newmago.Tempestad();
        Assert.AreEqual(360, newmago.Daño);
        }  
           
*/