using Android.App;
using Android.Widget;
using Android.OS;
using RadialProgress;
using System.Timers;
using System;

namespace cronometro
{
	[Activity(Label = "cronometro", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		RadialProgressView radialProgressview;
		Button bntStart;
		Button btnStop;
		TextView txtTimer;
		Timer timer;
		int hour = 0, min = 0, sec = 0;



		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);


			radialProgressview = FindViewById<RadialProgressView>(Resource.Id.progressView);
			bntStart = FindViewById<Button>(Resource.Id.btnStart);
			btnStop = FindViewById<Button>(Resource.Id.btnStop);
			txtTimer = FindViewById<TextView>(Resource.Id.txtTimer);


			bntStart.Click += delegate
			{
				timer = new Timer();
				timer.Interval = 1000;// representa un segundo
				timer.Elapsed += Timer_Elapsed;
				timer.Start();


			};
			btnStop.Click += delegate {
				timer.Dispose();
				timer = null;
				
};

		}
		void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			sec++;
			if (sec == 60)
			{
				min++;
				sec = 0;
			}
			if (min == 60)
			{
				hour++;
				min = 0;

			}
			RunOnUiThread(() => { txtTimer.Text = $"{hour}:{min}:{sec}"; });
			radialProgressview.Value = sec;
		}
	}

}

