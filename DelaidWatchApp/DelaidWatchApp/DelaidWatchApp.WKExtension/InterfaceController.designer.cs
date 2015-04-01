// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DelaidWatchApp.WKExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceGroup AltRoutesBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel DescLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceGroup FavBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel InfoHeaderLbl { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceGroup InnerGroup { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceTimer MinSecTimer { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceTimer MinutesTimer { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceGroup MsgBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceGroup OuterProgress { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel TimeLbl { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AltRoutesBtn != null) {
				AltRoutesBtn.Dispose ();
				AltRoutesBtn = null;
			}
			if (DescLbl != null) {
				DescLbl.Dispose ();
				DescLbl = null;
			}
			if (FavBtn != null) {
				FavBtn.Dispose ();
				FavBtn = null;
			}
			if (InfoHeaderLbl != null) {
				InfoHeaderLbl.Dispose ();
				InfoHeaderLbl = null;
			}
			if (InnerGroup != null) {
				InnerGroup.Dispose ();
				InnerGroup = null;
			}
			if (MinSecTimer != null) {
				MinSecTimer.Dispose ();
				MinSecTimer = null;
			}
			if (MinutesTimer != null) {
				MinutesTimer.Dispose ();
				MinutesTimer = null;
			}
			if (MsgBtn != null) {
				MsgBtn.Dispose ();
				MsgBtn = null;
			}
			if (OuterProgress != null) {
				OuterProgress.Dispose ();
				OuterProgress = null;
			}
			if (TimeLbl != null) {
				TimeLbl.Dispose ();
				TimeLbl = null;
			}
		}
	}
}
