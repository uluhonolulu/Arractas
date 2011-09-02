using System;
using MbUnit.Framework;

namespace Arractas {
	public abstract class BaseQueryTest<TContext, TResult> : BaseContextTest<TContext> where TContext : IContext, new() {

		public TResult Result { get; private set; }

		[FixtureSetUp]
		public override void Arrange() {
			base.Arrange();
			using (Context.ActionWrapper()) {
				Result = Act();
			}
		}

		public abstract TResult Act();

	}
}
