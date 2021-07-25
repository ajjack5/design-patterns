namespace DesignPatterns.Creational.Builder.CSharp.Implementation
{
    public class Director
    {
        public Option BuildOption()
        {
            IBuilder<Option> optionBuilder = new OptionBuilder();

            optionBuilder.Reset();
            optionBuilder.SetSpecific(42);

            return optionBuilder.GetInstance();
        }

        public Question BuildQuestion()
        {
            IBuilder<Question> questionBuilder = new QuestionBuilder();

            questionBuilder.Reset();
            questionBuilder.SetSpecific(45);
            questionBuilder.SetOtherSpecific(66);

            return questionBuilder.GetInstance();
        }
    }
}
