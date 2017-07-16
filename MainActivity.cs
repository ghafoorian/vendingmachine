using Android.App;
using Android.Widget;
using Android.OS;

namespace VendingMachineRecipes
{
    [Activity(Label = "VendingMachineRecipes", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

          
            SetContentView (Resource.Layout.Main);
            Button HotChocolate = FindViewById<Button>(Resource.Id.hotchocolate);
            Button WhiteCoffee = FindViewById<Button>(Resource.Id.whitecoffeewithsugar);
            Button LemonTea = FindViewById<Button>(Resource.Id.lemontea);
            Button IcedCoffee = FindViewById<Button>(Resource.Id.icedcoffee);

            HotChocolate.Click += delegate {
                Toast.MakeText(this, "Hot Chocolate", ToastLength.Long).Show();
                };
            WhiteCoffee.Click += delegate {
                Toast.MakeText(this, "White Coffee with 1 sugar", ToastLength.Long).Show();
            };
            LemonTea.Click += delegate {
                Toast.MakeText(this, "Lemon Tea", ToastLength.Long).Show();
            };
            IcedCoffee.Click += delegate {
                Toast.MakeText(this, "Iced Coffee", ToastLength.Long).Show();
                };
        }
    }
}

