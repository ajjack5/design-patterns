namespace DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics
{
    public class NewTable : Table
    {
        public NewTable()
        {
            FurnitureStyle = FurnitureStyle.New;
            Legs = 6;
            SeatPositions = 8;
        }
    }
}
