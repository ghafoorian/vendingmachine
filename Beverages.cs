using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace VendingMachineRecipes
{
    [Activity(Label = "Beverages")]
    public class Beverages : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.beverages);

        }

        public void AddWater()
        {
            Toast.MakeText(this, "Add Water", ToastLength.Long).Show();
        }

        public void BoilWater()
        {
            Toast.MakeText(this, "Boil Water", ToastLength.Long).Show();
        }
    }
}