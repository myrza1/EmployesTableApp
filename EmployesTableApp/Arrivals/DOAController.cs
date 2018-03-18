using EmployesTableApp.Domain;
using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace EmployesTableApp
{
    public partial class DOAController : UITableViewController
    {
        Order currentOrder { get; set; }
        public ArrivalDetailViewController Delegate { get; set; }
        List<OrderType> orderTypes;
        private string orderName;

        public float Liters
        {
            get;
            set;
        }
        public float Density
        {
            get;
            set;
        }
        public string  Manni
        {
            get;
            set;
        }
        public string Fuel_Flip_Mo
        {
            get;
            set;
        }



        public string X_Name
        {
            get;
            set;
        }

        public int Order_ID
        {
            get;
            set;
        }
        partial void DeteleOrder(UIButton sender)
        {
            Delegate.DeleteTask(currentOrder);
        }

        public string OrderStatus
        {
            get;
            set;
        }

        public int Flight_ID
        {
            get;
            set;
        }
        public string OrderName { get => orderName; set => orderName = value; }

        public void SetTask(ArrivalDetailViewController d, Order order)
        {
            Delegate = d;
            currentOrder = order;
        }

       

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            orderTypes = new List<OrderType>{
            new OrderType{Name = "Follow Me",Type = "BAS"},
            new OrderType{Name = "Towing",Type = "BAS"},
            new OrderType{Name = "PushBack",Type = "BAS"},
            new OrderType{Name = "Post Flight Maintenance",Type = "BAS"},
            new OrderType{Name = "Passenger Steps",Type = "BAS"},
                new OrderType{Name = "Passenger Disembarkation / Embarkation",Type = "BAS"},
                new OrderType{Name = "Baggage Handling",Type = "BAS"},
                new OrderType{Name = "Cargo Handling",Type = "BAS"},
                new OrderType{Name = "Removal chocks",Type = "BAS"},

                new OrderType{Name = "Fuel",Type = "FUE"},

                new OrderType{Name = "Ground Power Unit",Type = "ADV"},
                new OrderType{Name = "Air Start Unit",Type = "ADV"},
                new OrderType{Name = "Water Services",Type = "ADV"},
                new OrderType{Name = "Lavatory Services",Type = "ADV"},
                new OrderType{Name = "Cabin Cleaning",Type = "ADV"},
                new OrderType{Name = "De-icing",Type = "ADV"},
                new OrderType{Name = "Catering",Type = "ADV"},
                new OrderType{Name = "Catering Delivery",Type = "ADV"},
                new OrderType{Name = "Passenger Shuttle",Type = "ADV"},
                new OrderType{Name = "Crew Transfer",Type = "ADV"},
                new OrderType{Name = "Others",Type = "ADV"},

        };

       
            UIPickerViewModel orderNameModel = new OrderNameModel(orderTypes,fuelViewCell);
            //orderNameModel.set
            OrderNamePicker.Model = orderNameModel;



            if (OrderName != null)
            {
                //orderNameModel.Selected.Text = OrderName;

                int indeccc = orderTypes.FindIndex(x => x.Name.Equals(orderName));

                OrderNamePicker.Select((int)indeccc,0,true);

                if (indeccc == -1 || orderTypes[indeccc].Type != "FUE") fuelViewCell.Hidden = true;

                FlipNOField.Text = Fuel_Flip_Mo;
                LiterField.Text = Liters.ToString();
                DensityField.Text = Density.ToString();
                KilosField.Text = Manni;

                DoneSwich.On = OrderStatus.Length > 4 ? true : false;
            }
            Flight_ID = Flight_ID;
        }
        public DOAController (IntPtr handle) : base (handle)
        {
        }

       
        partial void SaveOrder(UIButton sender)
        {

            currentOrder.Name = orderTypes[(int)OrderNamePicker.SelectedRowInComponent(0)].Name;
            //    currentOrder.order = OrderStatus;
            currentOrder.Status = DoneSwich.On ? "Encluded" : "No";
            currentOrder.Order_ID = Order_ID;

            if (orderTypes[(int)OrderNamePicker.SelectedRowInComponent(0)].Type == "FUE"){
                currentOrder.Liters = Convert.ToInt32(LiterField.Text);
                currentOrder.Doc_no = FlipNOField.Text;
                currentOrder.Density = Convert.ToInt32(DensityField.Text);
                currentOrder.Mani = KilosField.Text;   
            }

            currentOrder.X_name = orderTypes[(int)OrderNamePicker.SelectedRowInComponent(0)].Type;
            Delegate.SaveTask(currentOrder);
        }
    }
}