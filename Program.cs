using System.Net.Mail;
using System.Net;

namespace Loose_Coupling_Principles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Gönderim yapacak Mail Adresi Giriniz:");
			string mymail = Console.ReadLine();

			Console.WriteLine("Gönderim yapacak Mail Adresinin Şifresini Giriniz:");
			string mymailsifre = Console.ReadLine();

			Console.WriteLine("Göndermek istediğiniz Mail Adresini Giriniz:");
			string MailAdresi = Console.ReadLine();

			Console.WriteLine("Göndermek istediğiniz Mesajı Giriniz:");

			string mesaj = Console.ReadLine();

			MailSender mailSender = new MailSender();

			string domain = GetDomainFromEmail(mymail);

			if (domain.Contains("hotmail"))
			{
				mailSender.SendMail(new Mail(), MailAdresi, mesaj, mymail, mymailsifre);
			}
			else if (domain.Contains("yandex"))
			{
				mailSender.SendMail(new Yandex(), MailAdresi, mesaj, mymail, mymailsifre);

			}
			else if (domain.Contains("gmail"))
			{
				mailSender.SendMail(new Gmail(), MailAdresi, mesaj, mymail, mymailsifre);
			}
			else
			{
				Console.WriteLine("Desteklenmeyen domain");
			}
			Console.ReadLine();
		}

		static string GetDomainFromEmail(string email)
		{
			int atIndex = email.IndexOf("@");
			if (atIndex != -1)
			{
				string domain = email.Substring(atIndex + 1).ToLower();
				return domain;
			}
			return string.Empty;
		}

	}
}