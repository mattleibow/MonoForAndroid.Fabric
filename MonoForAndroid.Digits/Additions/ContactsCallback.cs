using System;
using Android.Runtime;

namespace Com.Digits.Sdk.Android
{
	public partial class ContactsCallback : global::Com.Twitter.Sdk.Android.Core.Callback
	{
		[Register ("failure", "(Lcom/twitter/sdk/android/core/TwitterException;)V", "GetFailure_Lcom_twitter_sdk_android_core_TwitterException_Handler")]
		public override unsafe void Failure(global::Com.Twitter.Sdk.Android.Core.TwitterException p0)
		{
			FailureImpl(p0);
		}

		[Register ("success", "(Lcom/twitter/sdk/android/core/Result;)V", "GetSuccess_Lcom_twitter_sdk_android_core_Result_Handler")]
		public override unsafe void Success (global::Com.Twitter.Sdk.Android.Core.Result p0) {
			SuccessImpl(p0);
		}

	}
}

