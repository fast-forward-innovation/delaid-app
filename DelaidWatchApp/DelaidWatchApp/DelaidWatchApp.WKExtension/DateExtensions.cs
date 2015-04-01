using System;
using Foundation;

namespace DelaidWatchApp.WKExtension
{
	public static class DateExtensions
	{
		public static NSDate ToNSDate(this DateTime date) {
			DateTime utc = date.ToUniversalTime ();
			return (NSDate) DateTime.SpecifyKind(utc, DateTimeKind.Utc);
		}
	}
}

