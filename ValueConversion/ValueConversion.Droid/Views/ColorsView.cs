using Android.App;
using MvvmCross.Droid.Views;

namespace ValueConversion.UI.Droid.Views
{
    [Activity]
    public class ColorsView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Colors);
        }
    }
}