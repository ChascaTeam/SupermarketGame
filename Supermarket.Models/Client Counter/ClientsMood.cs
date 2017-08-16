namespace Supermarket.Models.Client_Counter
{
    using Supermarket.Models.Interfaces;

    public class ClientsMood : IClientCounter
    {
        private int satisfiedNumber;
        private int unsatisfiedNumber;

        public ClientsMood()
        {
            this.SatisfiedNumber = 0;
            this.UnsatisfiedNumber = 0;
        }

        public int SatisfiedNumber
        {
            get { return this.satisfiedNumber; }
            set { this.satisfiedNumber = value; }
        }

        public int UnsatisfiedNumber
        {
            get { return this.unsatisfiedNumber; }
            set { this.unsatisfiedNumber = value; }
        }

        public void AddSatisfied()
        {
            this.SatisfiedNumber++;
        }

        public void AddUnsatisfied()
        {
            this.UnsatisfiedNumber++;
        }

        public void Clear()
        {
            this.SatisfiedNumber = 0;
            this.UnsatisfiedNumber = 0;
        }
    }
}
