namespace DesignPatterns.Creational.Builder.CSharp.Implementation
{
    public class OptionBuilder : IBuilder<Option>
    {
        private Option _Option { get; set; } = new Option();

        public Option GetInstance()
        {
            return _Option;
        }

        public void Reset()
        {
            _Option = new Option();
        }

        public void SetSpecific(int number)
        {
            _Option.SpecificData = number + 500;
        }

        public void SetOtherSpecific(int number)
        {
            return;
        }
    }
}
