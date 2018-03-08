using Foundation;
using System;
using UIKit;
using EmployesTableApp.Domain;
using System.Collections.Generic;

namespace EmployesTableApp
{
    public partial class ArrivalDetailViewController : UIViewController
    {

        List<Order> orders = new List<Order>();



        public string FlightNumber
        {
            get;
            set;
        }

        public int Flight_ID
        {
            get;
            set;
        }
        public ArrivalDetailViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            Title = FlightNumber;


            RefServiceTSE.Service1 proxy = new RefServiceTSE.Service1();

            RefServiceTSE.Order[] ordersF = proxy.getFlightOrdersArrivals(Convert.ToInt32(Flight_ID),true);


            RefServiceTSE.Order orderF = new RefServiceTSE.Order();

            Order order;

            foreach (var item in ordersF)
            {
                order = new Order();
                order.Name = item.Name;
                order.Status = item.Status;
                order.Flight_id = item.Flight_id;
                orders.Add(order);
            }



           

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            OrderArrivalTableVIew.Source = new OrdersTVS(orders);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var orderDetailController = segue.DestinationViewController as DetailOrderArrivalController;


            NSIndexPath indexCell = OrderArrivalTableVIew.IndexPathForSelectedRow;

            //OrderArrivalTableVIew.Source = new OrdersTVS(orders);
            orderDetailController.OrderName = orders[indexCell.Row].Name;
            orderDetailController.Flight_ID = orders[indexCell.Row].Flight_id;
            orderDetailController.SetTask(this,orders[indexCell.Row]);
        }

        partial void CreateOrder(UIBarButtonItem sender)
        {
            
            //int newFlightID = orders[orders.Count - 1].Flight_id + 1;
            Order newOrder = new Order { Flight_id = Flight_ID };
            var detail = Storyboard.InstantiateViewController("detail") as DetailOrderArrivalController;


            orders.Add(newOrder);

            detail.SetTask(this,newOrder);
            NavigationController.PushViewController(detail,true);
        }

        public void DeleteTask(Order order){
            var oldOrder = orders.Find(t => t.Flight_id == order.Flight_id);
            orders.Remove(oldOrder);
        }

        public void SaveTask(Order order)
        {
            var oldOrder = orders.Find(t => t.Flight_id == order.Flight_id);
            NavigationController.PopViewController(true);
        }

        public static implicit operator ArrivalDetailViewController(ArrivalsViewController v)
        {
            throw new NotImplementedException();
        }
    }
}