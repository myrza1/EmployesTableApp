using Foundation;
using System;
using UIKit;

using System.Xml;

namespace EmployesTableApp
{
    public partial class FlightsCell : UITableViewCell
    {
        public FlightsCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(Flight flight)
        {
            FlightNumber.Text = flight.AirlineDesignatorIATA + flight.FlightNumber;
            ScheduleLabel.Text = flight.ScheduledTime.ToString("hh:mm");
            DestinationLabel.Text = flight.filght_from;
            //AircraftType.Text = flight.AircraftType;
            AircraftReg.Text = flight.AircraftRegistration;

        }


        internal void LikeCell()
        {
            FlightNumber.Text += " (like)";
        }


    }
}