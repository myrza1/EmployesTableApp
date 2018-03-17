using System;
namespace EmployesTableApp.Domain
{
    public class Order
    {
        private string name;
        private string status;
        private string doc_no;
        private string mani;
        private DateTime start_time;
        private DateTime end_time;
        private float liters;
        private float density;

        private int flight_id;
        private bool statusDone;
        private int order_ID;
        private string x_name;

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Doc_no
        {
            get
            {
                return doc_no;
            }

            set
            {
                doc_no = value;
            }
        }

        public string Mani
        {
            get
            {
                return mani;
            }

            set
            {
                mani = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime Start_time
        {
            get
            {
                return start_time;
            }

            set
            {
                start_time = value;
            }
        }

        public DateTime End_time
        {
            get
            {
                return end_time;
            }

            set
            {
                end_time = value;
            }
        }

        public float Liters
        {
            get
            {
                return liters;
            }

            set
            {
                liters = value;
            }
        }

        public float Density
        {
            get
            {
                return density;
            }

            set
            {
                density = value;
            }
        }

        public int Flight_id
        {
            get
            {
                return flight_id;
            }

            set
            {
                flight_id = value;
            }
        }

        public int Order_ID { get => order_ID; set => order_ID = value; }
        public string X_name { get => x_name; set => x_name = value; }
   
    }
}
