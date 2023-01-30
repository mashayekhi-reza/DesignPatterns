using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Structural
{
	public class RefinedAbstractionA : Abstraction
	{
		public RefinedAbstractionA(IImplementor implementor) : base(implementor)
		{
		}

		public override string Operation()
		{
			return $"{this.GetType().Name}: {_implementor.OperationImp()}";
		}
	}
}
