namespace NumbertronApp
{
    public abstract class Gambler
    {
        public string Name { get; }

        public int Score { get; protected set; }

        public abstract void FetchNewNumber(int num);

        protected Gambler(string name)
        {
            Name = name;
        }
    }
}
