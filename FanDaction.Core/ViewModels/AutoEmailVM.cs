namespace FanDaction.Core.ViewModels
{
    public class EmailTemplateVM
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public string Subject { get; set; }

        public string Reserved { get; set; }

        public bool Enabled { get; set; }

        public string Token { get; set; }
    }
}
