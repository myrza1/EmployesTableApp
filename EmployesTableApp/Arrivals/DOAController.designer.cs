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
    [Register ("DOAController")]
    partial class DOAController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeleteButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField DensityField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch DoneSwich { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField FlipNOField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell fuelViewCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField KilosField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LiterField { get; set; }

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

            if (DensityField != null) {
                DensityField.Dispose ();
                DensityField = null;
            }

            if (DoneSwich != null) {
                DoneSwich.Dispose ();
                DoneSwich = null;
            }

            if (FlipNOField != null) {
                FlipNOField.Dispose ();
                FlipNOField = null;
            }

            if (fuelViewCell != null) {
                fuelViewCell.Dispose ();
                fuelViewCell = null;
            }

            if (KilosField != null) {
                KilosField.Dispose ();
                KilosField = null;
            }

            if (LiterField != null) {
                LiterField.Dispose ();
                LiterField = null;
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