using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Squareup.Picasso;

namespace XamarinWithNativeLibraries
{
    [Activity(Label = "Page2Activity")]
    public class Page2Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.page2_layout);
            ImageView imageView = FindViewById<ImageView>(Resource.Id.imageView);

            // Use the Picasso jar library to load and display this image:
            Picasso.With(this)
                .Load("https://i.imgur.com/DvpvklR.jpg")
                .Into(imageView);
        }
    }
}