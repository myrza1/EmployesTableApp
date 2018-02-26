using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace EmployesTableApp
{
    internal class FlightsTVS : UITableViewSource
    {
        private List<Flight> flights;

        public FlightsTVS(List<Flight> flights)
        {
            this.flights = flights;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (FlightsCell)tableView.DequeueReusableCell("cell_id", indexPath);

            var flight = flights[indexPath.Row];

            cell.UpdateCell(flight);

            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return flights.Count;
        }
    }
}