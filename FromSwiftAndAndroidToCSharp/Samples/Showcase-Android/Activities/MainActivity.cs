﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Com.Liferay.Mobile.Screens.Asset;
using Com.Liferay.Mobile.Screens.Dlfile.Display.Video;
using Java.Lang;

namespace ShowcaseAndroid
{
    [Activity(MainLauncher = true)]
    public class MainActivity : AppCompatActivity, View.IOnClickListener, IVideoDisplayScreenletListener
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainView);

            FindViewById(Resource.Id.login_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.forgot_password_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.sign_up_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.ddl_form_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.user_portrait_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.web_content_display_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.asset_list_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.asset_display_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.image_display_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.pdf_display_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.audio_display_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.video_display_screenlet).SetOnClickListener(this);
            FindViewById(Resource.Id.image_gallery_screenlet).SetOnClickListener(this);
        }

        /* IOnClickListener */

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.login_screenlet:
                    StartActivity(typeof(LoginActivity));
                    break;
                case Resource.Id.forgot_password_screenlet:
                    StartActivity(typeof(ForgotPasswordActivity));
                    break;
                case Resource.Id.sign_up_screenlet:
                    StartActivity(typeof(SignUpActivity));
    				break;
                case Resource.Id.ddl_form_screenlet:
                    StartActivity(typeof(DDLFormActivity));
    				break;
                case Resource.Id.user_portrait_screenlet:
                    StartActivity(typeof(UserPortraitActivity));
    				break;
                case Resource.Id.web_content_display_screenlet:
                    StartActivity(typeof(WebContentDisplayActivity));
    				break;
                case Resource.Id.asset_list_screenlet:
                    StartActivity(typeof(AssetListActivity));
                    break;
                case Resource.Id.asset_display_screenlet:
                    StartActivity(typeof(AssetDisplayActivity));
                    break;
                case Resource.Id.image_display_screenlet:
                    StartActivity(typeof(ImageDisplayActivity));
                    break;
                case Resource.Id.pdf_display_screenlet:
                    StartActivity(typeof(PdfDisplayActivity));
                    break;
                case Resource.Id.audio_display_screenlet:
                    StartActivity(typeof(AudioDisplayActivity));
                    break;
                case Resource.Id.video_display_screenlet:
                    StartActivity(typeof(VideoDisplayActivity));
                    break;
                case Resource.Id.image_gallery_screenlet:
                    StartActivity(typeof(ImageGalleryActivity));
                    break;
            }
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

        public void OnRetrieveAssetSuccess(AssetEntry p0)
        {
            throw new System.NotImplementedException();
        }

        public void Error(Exception p0, string p1)
        {
            throw new System.NotImplementedException();
        }
    }
}