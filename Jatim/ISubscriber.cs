using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatim
{
	/// <summary>
	/// Subscriber for some message type is a class that implements this
	/// interface. Every time message is sent, all matching classes are
	/// constructed from DI container and method Handle is called on them.
	/// </summary>
    public interface ISubscriber<TMessage>
    {
		Task Handle(Envelope<TMessage> envelope);
    }
}
