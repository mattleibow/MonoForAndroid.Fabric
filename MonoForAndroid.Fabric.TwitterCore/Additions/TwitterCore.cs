using System;
using Android.Runtime;

namespace Com.Twitter.Sdk.Android.Core
{
	public partial class TwitterCore : global::IO.Fabric.Sdk.Android.Kit 
	{
		[Register("doInBackground", "()Ljava/lang/Object;", "GetDoInBackgroundHandler")]
		protected override unsafe global::Java.Lang.Object DoInBackground()
		{
			return DoInBackgroundImpl();
		}

		public override unsafe int CompareTo(Java.Lang.Object another)
		{
			return 0;
		}
	}
}
