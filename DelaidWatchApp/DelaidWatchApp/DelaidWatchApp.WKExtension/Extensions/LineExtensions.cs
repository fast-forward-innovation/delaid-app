using System;
using UIKit;
using DelaidBase;
using Foundation;

namespace DelaidWatchApp.WKExtension.Extensions
{
	public static class LineExtensions
	{		
		public static UIColor GetUIColor(this Line line) {
			int hash = line.Color;
			return new UIColor (((hash & 0xFF) >> 24) / 255f, ((hash & 0xFF) >> 16) / 255f, ((hash & 0xFF) >> 8) / 255f, 1f);
		}
	}
}

