using System;

using WatchKit;
using Foundation;
using System.Collections.Generic;
using DelaidBase;
using Newtonsoft.Json;
using System.Linq;
using DelaidWatchApp.WKExtension.Extensions;

namespace DelaidWatchApp.WKExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
		private List<Line> lines = new List<Line>();

        public InterfaceController(IntPtr handle)
            : base(handle)
        {
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);

			//get lines here OR determine line based off position? (communicate with iOS app to get line info if nothing is cached)
			var userDefaults = NSUserDefaults.StandardUserDefaults;
			var lineInfo = userDefaults.StringForKey ("line_info");
			if (!string.IsNullOrEmpty (lineInfo)) {
				//lines are cached. load them(may want to still communicate with the app to check the line statuses).
				lines = JsonConvert.DeserializeObject<List<Line>>(lineInfo);
			} else {
				//communicate with iOS app for line info
				//TODO add logic in iOS app to get lines. For now I'm just using dummy data
				Line line1 = new Line("test1", 8120837);
				line1.Trains.Add (1, new Train (1, DateTime.Now.Add (TimeSpan.FromMinutes (50)), true));
				line1.Trains.Add (2, new Train (2, DateTime.Now.Add (TimeSpan.FromMinutes (123)), false));
				line1.Trains.Add (3, new Train (3, DateTime.Now.Add (TimeSpan.FromMinutes (240)), false));

				Line line2 = new Line("test2", 8092670);
				line2.Trains.Add (4, new Train (4, DateTime.Now.Add (TimeSpan.FromMinutes (65)), false));
				line2.Trains.Add (5, new Train (5, DateTime.Now.Add (TimeSpan.FromMinutes (95)), false));
				line2.Trains.Add (6, new Train (6, DateTime.Now.Add (TimeSpan.FromMinutes (120)), false));

				lines.Add (line1);
				lines.Add (line2);
			}

			LineTable.SetNumberOfRows (lines.Count, "default");

			for (int i = 0; i < LineTable.NumberOfRows; i++) {
				var rowController = LineTable.GetRowController (i) as RowController;
				var line = lines [i];
				rowController.SetInfo (line.Name, line.GetUIColor ());
			}
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

			//cache line info
			var userDefaults = NSUserDefaults.StandardUserDefaults;
			userDefaults.SetString(JsonConvert.SerializeObject(lines), "line_info");
        }

		public override void DidSelectRow (WKInterfaceTable table, nint rowIndex)
		{
			var line = lines.ElementAt ((int)rowIndex);
			var trains = line.Trains;
			string[] names = Enumerable.Range(0, trains.Count).Select(x => "trainInfoController").ToArray();
			NSObject[] contexts = new NSObject[trains.Count];
			int index = 0;
			foreach (KeyValuePair<int, Train> keypair in trains) {
				contexts [index++] = (NSString)JsonConvert.SerializeObject(keypair.Value);
			}
			PresentController (names, contexts);
		}
    }
}

