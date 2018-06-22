using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace DD_App
{
    [Activity(Label = "Spinner_Demo_Two", MainLauncher = true)]
    public class Spinner_Demo_Two : AppCompatActivity
    {
        private Spinner sp;
        private string[] mItems;
        private ArrayAdapter adapter;
        //private Spinner sp2;
        //private Spinner sp3;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);

                // Create your application here
                SetContentView(Resource.Layout.spinner_demo_two_lyt);
                findViews();
                /*mItems = Resources.GetStringArray(Resource.Array.spinner_items);
                adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.spinner_items, Resource.Layout.support_simple_spinner_dropdown_item);
                adapter.SetDropDownViewResource(Resource.Mipmap.bg_spinner);
                sp.Adapter = adapter;*/
            }
            catch (Exception)
            {

                throw;
            }


        }

        void findViews()
        {
            sp = FindViewById<Spinner>(Resource.Id.custom_sp);
            //sp2 = FindViewById<Spinner>(Resource.Id.custom_sp2);
            //sp3 = FindViewById<Spinner>(Resource.Id.custom_sp3);
        }
    }
}