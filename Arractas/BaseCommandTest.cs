using System;
using MbUnit.Framework;

namespace Arractas {
	public abstract class BaseCommandTest<TContext> : BaseContextTest<TContext> where TContext : IContext, new() {

		[FixtureSetUp]
		public override void Arrange() {
			base.Arrange();
			using (Context.ActionWrapper()) {
				Act();
			}
		}

		public abstract void Act();

	}
}
