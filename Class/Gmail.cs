using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_Principles
{
	class Gmail : IMailService
	{

		public void Send(string to, string body, string mymail, string mymailpassword)
		{
			using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
			{
				client.EnableSsl = true;
				client.Credentials = new NetworkCredential(mymail, mymailpassword);

				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(mymail);
				mailMessage.To.Add(to);
				mailMessage.Subject = "Konu: Gmail Gönderimi";
				mailMessage.Body = body;

				client.Send(mailMessage);

				Console.WriteLine("Gönderilen:" + to + " Mesaj:" + body);
				Console.WriteLine("Gmail Gönderimi Başarılı");
			}
		}
	}
}
