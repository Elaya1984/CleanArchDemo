using CleanArchDomain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchDomain.Core.Command
{
	public class Command : Message
	{
		public DateTime TimeStamp { get; protected set; }

		protected Command()
		{
			TimeStamp = DateTime.Now;
		}
	}
}
