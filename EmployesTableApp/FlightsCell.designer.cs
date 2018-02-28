// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace EmployesTableApp
{
    [Register ("FlightsCell")]
    partial class FlightsCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AircraftReg { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel DestinationLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FlightNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ScheduleLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AircraftReg != null) {
                AircraftReg.Dispose ();
                AircraftReg = null;
            }

            if (DestinationLabel != null) {
                DestinationLabel.Dispose ();
                DestinationLabel = null;
            }

            if (FlightNumber != null) {
                FlightNumber.Dispose ();
                FlightNumber = null;
            }

            if (ScheduleLabel != null) {
                ScheduleLabel.Dispose ();
                ScheduleLabel = null;
            }
        }
    }
}