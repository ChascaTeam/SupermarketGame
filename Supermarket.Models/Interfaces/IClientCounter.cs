namespace Supermarket.Models.Interfaces
{
    public interface IClientCounter
    {
        int SatisfiedNumber { get; set; }

        int UnsatisfiedNumber { get; set; }

        void Clear();

        void AddSatisfied();

        void AddUnsatisfied();
    }
}
