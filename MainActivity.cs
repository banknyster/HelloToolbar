using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace App2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var button1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var button2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var button3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
            var button4 = FindViewById<ImageButton>(Resource.Id.imageButton4);

            button1.Click += delegate {
                OnButtonClickedButton1();
            };
            button2.Click += delegate {
                OnButtonClickedButton2();
            };
            button3.Click += delegate {
                OnButtonClickedButton3();
            };
            button4.Click += delegate {
                OnButtonClickedButton4();
            };
        }
        public void OnButtonClickedButton1(){
            Toast.MakeText(this, "Edit ", ToastLength.Long).Show();
        }
        public void OnButtonClickedButton2()
        {
            Toast.MakeText(this, "Undo ", ToastLength.Long).Show();
        }
        public void OnButtonClickedButton3()
        {
            Toast.MakeText(this, "Redo ", ToastLength.Long).Show();
        }
        public void OnButtonClickedButton4()
        {
            Toast.MakeText(this, "Save ", ToastLength.Long).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}