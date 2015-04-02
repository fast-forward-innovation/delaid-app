using System;
using Foundation;
using UIKit;

namespace DelaidWatchApp.WKExtension
{
	public partial class RowController : NSObject
	{
		public RowController() {
		}

		public void SetInfo(string lineName, UIColor color) {
			LineLbl.SetText (lineName);
			LineLbl.SetTextColor (color);
		}
	}
}

