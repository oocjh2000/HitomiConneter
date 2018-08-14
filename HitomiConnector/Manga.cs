using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HitomiConnector
{
    class Manga
    {
        public Drawable drawable;
        public string title;
        public string Sense;
        public string Tags;
        public void Setdrawable(Drawable _drawable)
        {
            drawable = _drawable;
        }
        public void SetManga(string Title,string sense,string tags)
        {
            title = Title;
            Sense = sense;
            Tags = tags;
        }

    }
}