namespace cafe.Models
{
    public class Clients : EFModel
    {
        public string NickName {  get; set; }
        public string Fullname {  get; set; }
        public int BonusPoint { get; set; }
        public string Email {  get; set; }

    }
}
