namespace RoleplayGame

{
    public interface ICharacter
    {
        public string Name {get; set;}
        public int QuantityLife {get; set;}

        public void Attack(ICharacter objetivo);



    }

}