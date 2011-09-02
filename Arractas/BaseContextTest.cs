using System;
using MbUnit.Framework;

namespace Arractas {
	public class BaseContextTest<TContext> where TContext : IContext, new() {
		public TContext Context { get; private set; }

		[FixtureSetUp]
		public virtual void Arrange() {
			Context = new TContext();
			using (Context.ActionWrapper()) {
				Context.Create();
			}
		}

		[FixtureTearDown]
		public virtual void CleanUp() {
			var disposable = Context as IDisposable;
			if (disposable != null)
				disposable.Dispose();
		}
	}
}
