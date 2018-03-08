using Foundation;
using System;
using UIKit;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace EmployesTableApp
{
    public partial class ArrivalsViewController : UIViewController
    {
        List<Flight> flights = new List<Flight>();

        public ArrivalsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            RefServiceTSE.Service1 proxy = new RefServiceTSE.Service1();

            RefServiceTSE.Flight[] flightsF = proxy.getFlightArrivals(DateTime.Today, true);


            RefServiceTSE.Flight flightF = new RefServiceTSE.Flight();

            Flight flight;

            foreach (var item in flightsF)
            {
                flight = new Flight();
                flight.FlightNumber = item.FlightNumber;
                flight.ScheduledTime = item.ScheduledTime;
                flight.FlightUniqueID = item.FlightUniqueID;
                flights.Add(flight);
            }


            //XmlElement root = proxy.GetFlights("d2ad08e1-8e92-46e5-9788-1e4e56457c18", DateTime.Today, true, DateTime.Today.AddHours(5), true, "TSE", TSEService.AirportIdentifierType.IATACode, true);
            //XElement rootX = XmlElementToXelement(root);
            //Functional.getFlights(rootX);
            ////Functional.ArrivalFligts
            //oflight = Functional.ArrivalFligts;


            FlightTableView.Source = new FlightsTVS(flights);

            FlightTableView.Delegate = new FlightsDelegate();

            FlightTableView.RowHeight = UITableView.AutomaticDimension;
            FlightTableView.EstimatedRowHeight = 90f;
            FlightTableView.ReloadData();

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var arrivalsDetailsViewController = segue.DestinationViewController as ArrivalDetailViewController;
            NSIndexPath indexCell = FlightTableView.IndexPathForSelectedRow;

            arrivalsDetailsViewController.FlightNumber = flights[indexCell.Row].FlightNumber;
            arrivalsDetailsViewController.Flight_ID = Convert.ToInt32(flights[indexCell.Row].FlightUniqueID);

           
        }



        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}