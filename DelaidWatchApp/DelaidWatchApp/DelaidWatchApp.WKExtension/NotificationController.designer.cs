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
	[Register ("NotificationController")]
	partial class NotificationController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel notificationAlertLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (notificationAlertLabel != null) {
				notificationAlertLabel.Dispose ();
				notificationAlertLabel = null;
			}
		}
	}
}
