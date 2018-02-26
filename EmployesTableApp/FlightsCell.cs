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
           


            FlightNumber.Text = flight.FlightNumber;
            ScheduleLabel.Text = flight.TAXIFUEL;
            DestinationLabel.Text = flight.arr_flight_type;
        }

        internal void LikeCell()
        {
            FlightNumber.Text += " (like)";
        }
    }
}