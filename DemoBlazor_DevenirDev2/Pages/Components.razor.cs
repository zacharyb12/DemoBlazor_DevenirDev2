namespace DemoBlazor_DevenirDev2.Pages
{
    public partial class Components
    {
        public int Value { get; set; } = 5;

        public void Increment()
        {
            Value++;
        }

        public void Decrement()
        {
            Value--;
        }
    }

}
