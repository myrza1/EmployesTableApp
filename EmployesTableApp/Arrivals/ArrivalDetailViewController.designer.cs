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
    [Register ("ArrivalDetailViewController")]
    partial class ArrivalDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem addButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView MyArirvalActivities { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView OrderArrivalTableVIew { get; set; }

        [Action ("CreateOrder:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CreateOrder (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (addButton != null) {
                addButton.Dispose ();
                addButton = null;
            }

            if (MyArirvalActivities != null) {
                MyArirvalActivities.Dispose ();
                MyArirvalActivities = null;
            }

            if (OrderArrivalTableVIew != null) {
                OrderArrivalTableVIew.Dispose ();
                OrderArrivalTableVIew = null;
            }
        }
    }
}