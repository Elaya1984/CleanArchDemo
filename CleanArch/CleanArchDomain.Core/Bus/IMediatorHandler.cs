using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleanArchDomain.Core.Command;
namespace CleanArchDomain.Core.Bus
{
	public interface IMediatorHandler
	{
		Task SendCommand<T>(T command) where T : CleanArchDomain.Core.Command.Command;
	}
}
