public class Reporter
{
    // public MailSender MailSender { get; set; }
    // private readonly MailSender mailSender;
    private readonly ISender sender;
    public Reporter()
    {
        
    }    
    
    public Reporter(ISender sender)
    {
        // this.mailSender = mailSender;
        this.sender = sender;
    }
    public void SendReport(/*MailSender mailsender*/)
    {
        // MailSender mailSender = new MailSender();

        // MailSender.Send();
        // mailSender.Send();
        sender.Send();
    }
}

public interface ISender
{
    void Send();
}
public class MailSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Mail ile gönderildi");
    }
}
public class WhatsappSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Whatsapp ile gönderildi");
    }
}
public class TelegramSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Telegram ile gönderildi");
    }
}
public class BiPSender : ISender
{
    public void Send()
    {
        Console.WriteLine("BiP ile gönderildi");
    }
}