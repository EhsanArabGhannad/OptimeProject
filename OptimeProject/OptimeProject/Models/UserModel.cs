namespace OptimeProject.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string PassWord { get; set; } = string.Empty;
        public string Credit { get; set; } = string.Empty;
        public DateTime CreditExpiration { get; set; }
    }
}
