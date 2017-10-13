using Android.App;
using Android.OS;
using Android.Widget;
using Com.Liferay.Mobile.Screens.Asset;
using Com.Liferay.Mobile.Screens.Asset.Display;
using Com.Liferay.Mobile.Screens.Dlfile.Display.Video;
using Java.Lang;

namespace ShowcaseAndroid
{
    [Activity]
    public class AssetDisplayActivity : Activity, IVideoDisplayScreenletListener, IAssetDisplayListener
    {
        AssetDisplayScreenlet assetDisplayScreenlet;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AssetDisplayView);

            assetDisplayScreenlet = 
                (AssetDisplayScreenlet) FindViewById(Resource.Id.asset_display_screenlet);
            assetDisplayScreenlet.Listener = this;
            assetDisplayScreenlet.LoadAsset();
            //assetDisplayScreenlet.Load();
        }

        /* IAssetDisplayListener */

        public void OnRetrieveAssetSuccess(AssetEntry p0)
        {
            Toast.MakeText(this, "Asset display success: " + p0.EntryId, ToastLength.Short).Show();
        }

        public void Error(Java.Lang.Exception p0, string p1)
		{
			System.Diagnostics.Debug.WriteLine($"Asset display failed: {p0}");
		}

        public void OnVideoCompleted()
        {
            throw new System.NotImplementedException();
        }

        public void OnVideoError(Exception p0)
        {
            throw new System.NotImplementedException();
        }

        public void OnVideoPrepared()
        {
            throw new System.NotImplementedException();
        }
    }
}
