using Android.App;
using Android.Widget;
using Android.OS;

using Com.Digits.Sdk.Android;
using System;

namespace DigitsDemo
{
	[Activity (Label = "DigitsDemo", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private DemoAuthCallback _authCallback;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			var button = FindViewById<DigitsAuthButton> (Resource.Id.DigitsAuthBtn);
			_authCallback = new DemoAuthCallback ();
			button.SetCallback (_authCallback);
		}
	}

	internal class DemoAuthCallback : Java.Lang.Object, IAuthCallback {
		public void Success(DigitsSession session, string phoneNumber) {
			Console.WriteLine (phoneNumber);
		}

		public void Failure(DigitsException e) {
			Console.WriteLine ("Error during Digits authentication: {0}", e.ToString ());
		}
	}
}


