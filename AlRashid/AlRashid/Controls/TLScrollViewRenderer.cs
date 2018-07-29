
using Android.Content;
using Xamarin.Forms.Platform.Android;


namespace AlRashid.Controls
{
    public class TLScrollViewRenderer : ScrollViewRenderer
    {


        public TLScrollViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var element = e.NewElement as TLScrollView;
            element?.Render();
        }
    }
}
