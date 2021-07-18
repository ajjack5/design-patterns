namespace DesignPatterns.Creational.Singleton.CSharp.Examples
{
    public class Universe
    {
        public long YearsSinceBigBang { get; set; }
        private static Universe _Existence { get; set; }

        private Universe() { }

        public static Universe BigBang()
        {
            if (_Existence == null)
            {
                _Existence = new Universe();
            }
            
            return _Existence;
        }

        public void TravelToTheEndOfTime()
        {
            YearsSinceBigBang = long.MaxValue;
        }

        public void TravelToTheBeginningOfTime()
        {
            YearsSinceBigBang = 0;
        }
    }
}
