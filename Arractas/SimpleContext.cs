using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arractas {
	public abstract class SimpleContext : IContext {
		public abstract void Create();
		public IDisposable ActionWrapper() {
			return new NullWrapper();
		}

		class NullWrapper : IDisposable {
			public void Dispose() {}
		}
	}
}
