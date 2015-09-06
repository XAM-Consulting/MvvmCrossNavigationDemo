using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

namespace MvvmCrossNavigationDemo.Droid
{
	[Activity (Label = "XamarinForm", Theme="@android:style/Theme.Holo.Light", NoHistory = true)]
	public class MvxFormsApplicationActivity
		: FormsApplicationActivity
	{
		public static Page CurrentPage;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Forms.Init (this, bundle);

			SetPage (CurrentPage);
		}
	}
}

