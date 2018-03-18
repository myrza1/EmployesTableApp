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

        int resultb = 1;
        bool resultorderB = false;

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

            MyArirvalActivities.Hidden = true;

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
                order.Order_ID = item.Order_id;
                order.Doc_no = item.Doc_no;

                order.Mani = item.Mani;
                order.Liters = item.Liters;
                order.Density = item.Density;

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

            var orderDetailController = segue.DestinationViewController as DOAController;


            NSIndexPath indexCell = OrderArrivalTableVIew.IndexPathForSelectedRow;

            //OrderArrivalTableVIew.Source = new OrdersTVS(orders);
            orderDetailController.OrderName = orders[indexCell.Row].Name;
            orderDetailController.Flight_ID = orders[indexCell.Row].Flight_id;
            orderDetailController.OrderStatus = orders[indexCell.Row].Status;
            orderDetailController.Order_ID = orders[indexCell.Row].Order_ID;
            orderDetailController.Fuel_Flip_Mo = orders[indexCell.Row].Doc_no;
            orderDetailController.Manni = orders[indexCell.Row].Mani;
            orderDetailController.Liters = orders[indexCell.Row].Liters;
            orderDetailController.Density = orders[indexCell.Row].Density;
            orderDetailController.SetTask(this,orders[indexCell.Row]);
        }

        partial void CreateOrder(UIBarButtonItem sender)
        {
            
            //int newFlightID = orders[orders.Count - 1].Flight_id + 1;
            Order newOrder = new Order { Flight_id = Flight_ID };
            var detail = Storyboard.InstantiateViewController("detail") as DOAController;


            orders.Add(newOrder);

            detail.SetTask(this,newOrder);
            NavigationController.PushViewController(detail,true);
        }

        public void DeleteTask(Order order){

            MyArirvalActivities.Hidden = false;
            MyArirvalActivities.StartAnimating();

            var oldOrder = orders.Find(t => t.Flight_id == order.Flight_id);

            orders.Remove(oldOrder);
            RefServiceTSE.Service1 proxy = new RefServiceTSE.Service1();
            RefServiceTSE.Order orderR = new RefServiceTSE.Order();

            try
            {
                proxy.owiryOrdersArrivalFlightsCompleted += owiryOrderCallBack;

                proxy.owiryOrdersArrivalFlightsAsync(order.Order_ID, true);

                NavigationController.PopViewController(true);
            }
            catch (Exception ex)
            {

            }



        }

        private void owiryOrderCallBack(object sender, RefServiceTSE.owiryOrdersArrivalFlightsCompletedEventArgs e)
        {
            var ee = e;


            MyArirvalActivities.StopAnimating();
            MyArirvalActivities.Hidden = true;
        }

        public void SaveTask(Order order)
        {
            MyArirvalActivities.Hidden = false;
            MyArirvalActivities.StartAnimating();

            var oldOrder = orders.Find(t => t.Order_ID == order.Order_ID);
            RefServiceTSE.Service1 proxy = new RefServiceTSE.Service1();
            RefServiceTSE.Order orderR = new RefServiceTSE.Order();
            //RefServiceTSE.O
           
            orderR.End_time = DateTime.Today;
            orderR.End_timeSpecified = true;
            orderR.Start_time = DateTime.Today;
            orderR.Start_timeSpecified = true;
            orderR.Name = order.Name;
            orderR.DensitySpecified = true;
            orderR.Order_id = order.Order_ID;
            orderR.Order_idSpecified = true;
            orderR.Status = order.Status;
            orderR.Flight_idSpecified = true;
            orderR.LitersSpecified = true;
            orderR.Movement_idSpecified = true;
            orderR.X_name = order.X_name;
            orderR.Mani = order.Mani;
            orderR.Density = order.Density;
            orderR.Doc_no = order.Doc_no;
            orderR.Flight_id = order.Flight_id;
            orderR.Liters = order.Liters;

            try
            {
                if (oldOrder.Order_ID == 0)
                {
                    //Қосамыз
                    proxy.kosytOrdersArrivalFlightsCompleted += kosyOrderCallBack;
                    proxy.kosytOrdersArrivalFlightsAsync(orderR);
                } else{
                    //Жаңартамыз
                    proxy.updateOrdersArrivalFlightsCompleted += updateCallBack;
                    proxy.updateOrdersArrivalFlightsAsync(orderR);
                }
               
                //proxy.updateOrdersArrivalFlights(orderR,out resultb,out resultorderB);


                NavigationController.PopViewController(true);
            }
            catch (Exception ex)
            {

            }

        }

        private void kosyOrderCallBack(object sender, RefServiceTSE.kosytOrdersArrivalFlightsCompletedEventArgs e)
        {
            var e1 = e;

            MyArirvalActivities.StopAnimating();
            MyArirvalActivities.Hidden = true;
        }

        public  void updateCallBack(object sender, RefServiceTSE.updateOrdersArrivalFlightsCompletedEventArgs e){
            var e1 = e;

            MyArirvalActivities.StopAnimating();
            MyArirvalActivities.Hidden = true;
        }
        public static implicit operator ArrivalDetailViewController(ArrivalsViewController v)
        {
            throw new NotImplementedException();
        }
    }
}