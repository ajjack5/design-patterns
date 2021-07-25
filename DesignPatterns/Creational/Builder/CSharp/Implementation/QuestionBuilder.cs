namespace DesignPatterns.Creational.Builder.CSharp.Implementation
{
    public class QuestionBuilder : IBuilder<Question>
    {
        private Question _Question { get; set; } = new Question();

        public Question GetInstance()
        {
            return _Question;
        }

        public void Reset()
        {
            _Question = new Question();
        }

        public void SetSpecific(int number)
        {
            _Question.SpecificData = number;
        }

        public void SetOtherSpecific(int number)
        {
            _Question.OtherSpecificData = number;
        }
    }
}
