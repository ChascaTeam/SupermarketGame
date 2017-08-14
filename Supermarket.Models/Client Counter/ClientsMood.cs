namespace Supermarket.Models.Client_Counter
{
    public class ClientsMood : IClientCounter
    {
        public ClientsMood()
        {
            this.SatisfiedNumber = 0;
            this.UnsatisfiedNumber = 0;
        }

        public int SatisfiedNumber { get; set; }

        public int UnsatisfiedNumber { get; set; }

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
