using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling_Principles
{
	public interface IMailService
	{
		public void Send(string to, string body, string mymail, string mymailpassword);
	}
}
