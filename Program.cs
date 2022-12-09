using System.Net;
using System.Net.Mail;


    for(int i = 0; i < 10000; i++)
    {
    Console.WriteLine("=============================================================================");
    Console.WriteLine("=============================SMOKY SENDER====================================");
    Console.WriteLine("=============================================================================");

    Console.WriteLine("Number of send: ");
    var count = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your smtp:");
    string host = Console.ReadLine();
    Console.WriteLine("Enter your mail:");
    string username = Console.ReadLine();
    Console.WriteLine("Enter your password:");
    string password = Console.ReadLine();
    Console.WriteLine("Enter your target:");
    string target = Console.ReadLine();
    Console.WriteLine("Subject:");
    string subject = Console.ReadLine();
    Console.WriteLine("Body:");
    string body = Console.ReadLine();

    SendMail(count, host, username, password, target, subject, body);


    if (i > 10000)
    {
        Environment.Exit(0);
    }
}
    
    


static void SendMail(int count,string host, string username, string password, string target, string subject, string body)
{
    try
    {
        for(int i = 0; i < count; i++)
        {
            
            SmtpClient client = new SmtpClient(host);
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(username);
            mail.To.Add(target);
            mail.Subject = subject;
            mail.Body = body;

            client.Port = 587;
            client.Credentials = new NetworkCredential(username, password);
            client.EnableSsl = true;

            client.Send(mail);
            
        }
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
    finally
    {
        Console.WriteLine("ALL EMAIL ARE SENT!!!");
    }
}




