using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_Principles
{
	public class MailSender
	{
		public void SendMail(IMailService mailService, string to, string body, string mymail, string mymailpassword)
		{
			mailService.Send(to, body, mymail, mymailpassword);
		}
	}
}
