namespace LabJob6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Mail.GetInstance();
            Mail.GetInstance().MailSender("dark_jokey@mail.ru","Привет");
            
        }
    }
}