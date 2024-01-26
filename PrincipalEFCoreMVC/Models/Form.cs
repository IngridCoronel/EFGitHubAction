namespace PrincipalEFCoreMVC.Models
{
    public class Form
    {
        public int Id { get; set; }
        public int IdFormSf { get; set; }
        public string IdSf { get; set; }
        public DateTime DateReceivedProcesar { get; set; }
        public DateTime DateSendProcesar { get; set; }
        public string Status { get; set; }
        public string reasenRejection { get; set; }
        public bool sentSf { get; set; }



    }
}
