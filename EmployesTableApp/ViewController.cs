﻿using EmployesTableApp.Data;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using UIKit;

namespace EmployesTableApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public XElement XmlElementToXelement(XmlElement e)
        {
            return XElement.Parse(e.OuterXml);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            TSEService.SITAAMSIntegrationService proxy = new TSEService.SITAAMSIntegrationService();
            XmlElement root = proxy.GetFlights("d2ad08e1-8e92-46e5-9788-1e4e56457c18", DateTime.Today, true, DateTime.Today.AddHours(5), true, "TSE", TSEService.AirportIdentifierType.IATACode, true);
            XElement rootX = XmlElementToXelement(root);
            Functional.getFlights(rootX);

            var flights = new List<Flight>
            {
                new Flight
                {
                    FlightNumber = "KC858",
                    TAXIFUEL  = "15:00",
                    filght_to = "Almaty"
                },
                new Flight
                {

                    FlightNumber = "KC859",
                    TAXIFUEL = "16:00",
                    filght_to = "Karagandy"
                }
            };

            FlightTableView.Source = new FlightsTVS(flights);

            FlightTableView.Delegate = new FlightsDelegate();

            FlightTableView.RowHeight = UITableView.AutomaticDimension;
            FlightTableView.EstimatedRowHeight = 90f;
            FlightTableView.ReloadData();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}