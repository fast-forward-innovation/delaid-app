﻿using System;

using WatchKit;
using Foundation;

namespace DelaidWatchApp.WKExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        public InterfaceController(IntPtr handle)
            : base(handle)
        {
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);

			var device = WKInterfaceDevice.CurrentDevice;

			OuterProgress.SetBackgroundImage ("CircleOutline");
			MsgBtn.SetBackgroundImage ("Msg");
			AltRoutesBtn.SetBackgroundImage ("AltRoutes");
			FavBtn.SetBackgroundImage ("Heart");

			//need to talk about using these
			//AddMenuItem ("AltRoutes", "Alternate Routes", SomeAction);
			//AddMenuItem ("Msg", "Messages", SomeAction);
			//AddMenuItem ("Heart", "Favorite", SomeAction);

			SetArrivalTime(DateTime.Now.Add(TimeSpan.FromMinutes(120)), false);
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }

		public void SomeAction() {
		}

		/// <summary>
		/// Sets the next trains arrival time.
		/// Handles all the display cases for the time:
		///     < 60 minutes a timer,
		///     > 60 minutes and < 100 minutes shows just the minutes
		///     > 90 minutes shows the arrival time
		/// </summary>
		/// <param name="time">Time of the trains arrival</param>
		/// <param name="delayed>If the train is delayed</param>
		public void SetArrivalTime(DateTime time, bool delayed) {
			TimeSpan timeTill = time - DateTime.Now;
			int minutes = (int) timeTill.TotalMinutes;

			//the ability to change the timers format would be awesome :/
			MinSecTimer.Stop ();
			MinutesTimer.Stop ();
			if (minutes < 60) {
				//Show timer with no desc label
				MinutesTimer.SetHidden(false);
				MinSecTimer.SetHidden(true);
				DescLbl.SetHidden(true);
				TimeLbl.SetHidden(true);
				MinutesTimer.SetDate (time.ToNSDate());
				MinutesTimer.Start ();
			} else if (minutes > 60 && minutes < 90) {
				MinutesTimer.SetHidden(false);
				DescLbl.SetHidden (false);
				MinSecTimer.SetHidden (true);
				TimeLbl.SetHidden(true);
				DescLbl.SetText ("MINS");
				MinutesTimer.SetDate (time.ToNSDate());
				MinutesTimer.Start ();
			} else {
				MinSecTimer.SetHidden(true);
				MinutesTimer.SetHidden (true);
				DescLbl.SetHidden (false);
				TimeLbl.SetHidden(false);

				var timeString = time.ToShortTimeString ();
				var period = timeString.Substring (timeString.Length - 2, 2);
				timeString = timeString.Substring (0, timeString.Length - 3); //remove AM/PM + space

				TimeLbl.SetText (timeString);
				DescLbl.SetText (period);
			}
		}
    }
}

