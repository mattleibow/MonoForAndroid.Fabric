
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Twitter.Sdk.Android.Core;
using IO.Fabric.Sdk.Android;
using Com.Digits.Sdk.Android;

namespace DigitsDemo
{
	[Application]	
	public class DigitsDemoApplication : Application
	{
		public DigitsDemoApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

			var authConfig = new TwitterAuthConfig (
				GetString(Resource.String.fabric_consumer_key), 
				GetString(Resource.String.fabric_consumer_secret)
			);
			Fabric.With (this, new TwitterCore (authConfig), new Digits ());
		}
	}
}

