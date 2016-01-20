using System;
using Android.Runtime;

namespace Com.Digits.Sdk.Android
{
	public partial class Digits : global::IO.Fabric.Sdk.Android.Kit {
		[Register ("doInBackground", "()Ljava/lang/Void;", "GetDoInBackgroundHandler")]
		protected override unsafe global::Java.Lang.Object DoInBackground ()
		{
			return DoInBackgroundImpl();
		}

		public override unsafe int CompareTo(Java.Lang.Object another)
		{
			return 0;
		}
	}
}

