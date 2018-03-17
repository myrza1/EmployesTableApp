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
    [Register ("DetailOrderArrivalController")]
    partial class DetailOrderArrivalController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeleteButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch DoneSwich { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ffff { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NameField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell ordername { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView OrderNamePicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView OrderTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SaveButton { get; set; }

        [Action ("DeteleOrder:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DeteleOrder (UIKit.UIButton sender);

        [Action ("SaveOrder:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SaveOrder (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (DeleteButton != null) {
                DeleteButton.Dispose ();
                DeleteButton = null;
            }

            if (DoneSwich != null) {
                DoneSwich.Dispose ();
                DoneSwich = null;
            }

            if (ffff != null) {
                ffff.Dispose ();
                ffff = null;
            }

            if (NameField != null) {
                NameField.Dispose ();
                NameField = null;
            }

            if (ordername != null) {
                ordername.Dispose ();
                ordername = null;
            }

            if (OrderNamePicker != null) {
                OrderNamePicker.Dispose ();
                OrderNamePicker = null;
            }

            if (OrderTableView != null) {
                OrderTableView.Dispose ();
                OrderTableView = null;
            }

            if (SaveButton != null) {
                SaveButton.Dispose ();
                SaveButton = null;
            }
        }
    }
}