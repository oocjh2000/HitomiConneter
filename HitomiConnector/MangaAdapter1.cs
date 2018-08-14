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
    class MangaAdapter1 : BaseAdapter
    {
        List<Manga> mangas = new List<Manga>();

        Context context;

        public MangaAdapter1(Context context)
        {
            this.context = context;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            
            Context context = parent.Context;
            if (convertView == null)
            {
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                convertView = inflater.Inflate(Resource.Layout.hitomiadapter, null);
               
            }
            ImageView title = convertView.FindViewById<ImageView>(Resource.Id.imageView1);
            TextView MangaName = convertView.FindViewById<TextView>(Resource.Id.MangaTitle);
            TextView Sense = convertView.FindViewById<TextView>(Resource.Id.textView2);
            TextView Tag = convertView.FindViewById<TextView>(Resource.Id.textView3);

            title.SetImageDrawable(mangas[position].drawable);
            MangaName.Text = mangas[position].title;
            Sense.Text = mangas[position].Sense;
            Tag.Text = mangas[position].Tags;

            return convertView;
        }
        public void AddItem(Drawable icon, string title, string sense, string tags)
        {
            Manga manga = new Manga();

            manga.Setdrawable(icon);

            manga.title = title;
            manga.Sense = sense;
            manga.Tags = tags;
            mangas.Add(manga);
        }
        //Fill in cound here, currently 0
        public override int Count => mangas.Count;


        class MangaAdapter1ViewHolder : Java.Lang.Object
        {
            //Your adapter views to re-use
            //public TextView Title { get; set; }
        }
    }
}