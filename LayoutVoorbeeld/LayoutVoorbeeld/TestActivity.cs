﻿
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

namespace LayoutVoorbeeld
{
	[Activity (Label = "TestActivity")]			
	public class TestActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.TestLayout);
			// Create your application here

			TextView textview1 = FindViewById<TextView> (Resource.Id.textView1);
			textview1.Text = "Fout";

		}
	}
}

