using System;
using Android.Runtime;
using Android.App;

namespace Com.Digits.Sdk.Android
{
	public interface IActivityLifecycle : IJavaObject
	{
		void OnDestroy();

		void OnResume();

		void OnActivityResult(int var1, int var2, Activity var3);
	}
}

