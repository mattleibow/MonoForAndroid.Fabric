using System;
using Android.Runtime;

namespace IO.Fabric.Sdk.Android.Services.Concurrency
{
	public partial class PriorityFutureTask
	{
		public virtual unsafe global::System.Collections.ICollection Dependencies
		{
			[Register("getDependencies", "()Ljava/util/Collection;", "GetGetDependenciesHandler")]
			get
			{
				return (global::System.Collections.ICollection)DependencyCollection();
			}
		}
	}
}