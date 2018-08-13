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
            var view = convertView;
            MangaAdapter1ViewHolder holder = null;

            if (view != null)
                holder = view.Tag as MangaAdapter1ViewHolder;

            if (holder == null)
            {
                holder = new MangaAdapter1ViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                convertView = inflater.Inflate(Resource.Layout.hitomiadapter, null);
                view.Tag = holder;
            }
            ImageView title = view.FindViewById<ImageView>(Resource.Id.imageView1);
            TextView MangaName = view.FindViewById<TextView>(Resource.Id.MangaTitle);
            TextView Sense = view.FindViewById<TextView>(Resource.Id.textView2);
            TextView Tag = view.FindViewById<TextView>(Resource.Id.textView3);

            return view;
        }
        public void AddItem(Drawable icon, string title, string sense, string tags)
        {
            Manga manga = new Manga();

            manga.Setdrawable(icon);

            manga.title = title;
            manga.Sense = sense;
            manga.Tags = tags;
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