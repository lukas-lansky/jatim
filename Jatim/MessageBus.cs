using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatim
{
	public class MessageBus
	{
		public async Task Publish<T>(T message)
		{
			var envelope = new Envelope<T>(message);

			// todo
		}

		private IEnumerable<Type> GetAllSubscribersFor(object message)
		{
			// todo

			return null;
		}
	}
}
