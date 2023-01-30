using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Structural
{
	public class ConcreteImplementorB : IImplementor
	{
		public string OperationImp()
		{
			return $"{this.GetType().Name} {System.Reflection.MethodBase.GetCurrentMethod()?.Name}";
		}
	}
}
