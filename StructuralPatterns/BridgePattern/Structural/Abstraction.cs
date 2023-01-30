using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Structural
{
	public abstract class Abstraction
	{
		protected readonly IImplementor _implementor;

		public Abstraction(IImplementor implementor)
		{
			_implementor = implementor;
		}

		public abstract string Operation();
	}
}
