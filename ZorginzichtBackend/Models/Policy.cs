namespace ZorginzichtBackend.Models
{
    public class Policy
    {
        public int ID { get; set; }

        public int PolicyNr { get; set; }

        public string PolicyName { get; set; } = "";

        public string Insurance { get; set; } = "";

        public float Costs { get; set; }
    }
}
