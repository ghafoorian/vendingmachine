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
    [Activity(Label = "IcedCoffee")]
    public class IcedCoffee : Activity 
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.beverages);
        }

        public void CrushIce()
        {

        }
        public void AddIceToBlender()
        {

        }
        public void AddCoffeeSyruptoBlender()
        {

        }
        public void BlendIngredients()
        {

        }
        public void AddIngredients()
        {

        }
    }
}