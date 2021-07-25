namespace DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics
{
    public class OldTable : Table
    {
        public OldTable()
        {
            FurnitureStyle = FurnitureStyle.Old;
            Legs = 4;
            SeatPositions = 4;
        }
    }
}
