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

namespace ATBI
{
    [Activity(Label = "RatingActivity")]
    public class RatingActivity : ListActivity
    {
        string[] items;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            items = new string[] { "Symptom1", "Symptom2", "Symptom3", "Symptom4", "Symptom5", "Symptom6" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
           // ListAdaoter2 = new ArrayAdapter<SeekBar>(this,Android.Resource.Layout.sim)
            // Create your application here
        }
    }
}