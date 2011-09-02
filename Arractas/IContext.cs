using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arractas {
	public interface IContext {
		void Create();
		IDisposable ActionWrapper();
	}
}
