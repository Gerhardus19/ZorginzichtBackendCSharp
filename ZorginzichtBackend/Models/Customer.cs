namespace ZorginzichtBackend.Models
{
    public class Customer
    {
        public int ID { get; set; }

        public int CustomerNumber { get; set; }

        public int PolicyID { get; set; }

        public string Name { get; set; } = "";
    }
}
