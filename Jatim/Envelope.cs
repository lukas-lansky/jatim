using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatim
{
	public class Envelope<TMessage>
	{
		public Envelope(TMessage message)
		{
			this.Message = message;
		}

		public TMessage Message { get; protected set; }

		public Type Sender { get; protected set; }
	}
}
