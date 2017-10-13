using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Liferay.Mobile.Screens.Base.List;

namespace Com.Liferay.Mobile.Screens.Imagegallery {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liferay.mobile.screens.imagegallery']/interface[@name='ImageGalleryListener']"
	[Register ("com/liferay/mobile/screens/imagegallery/ImageGalleryListener", "", "Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListenerInvoker")]
	public partial interface IImageGalleryListener : global::Com.Liferay.Mobile.Screens.Base.List.IBaseListListener
    {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liferay.mobile.screens.imagegallery']/interface[@name='ImageGalleryListener']/method[@name='onImageEntryDeleted' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onImageEntryDeleted", "(J)V", "GetOnImageEntryDeleted_JHandler:Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListenerInvoker, LiferayScreens_Android")]
		void OnImageEntryDeleted (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liferay.mobile.screens.imagegallery']/interface[@name='ImageGalleryListener']/method[@name='onImageUploadEnd' and count(parameter)=1 and parameter[1][@type='com.liferay.mobile.screens.imagegallery.model.ImageEntry']]"
		[Register ("onImageUploadEnd", "(Lcom/liferay/mobile/screens/imagegallery/model/ImageEntry;)V", "GetOnImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_Handler:Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListenerInvoker, LiferayScreens_Android")]
		void OnImageUploadEnd (global::Com.Liferay.Mobile.Screens.Imagegallery.Model.ImageEntry p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liferay.mobile.screens.imagegallery']/interface[@name='ImageGalleryListener']/method[@name='onImageUploadProgress' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onImageUploadProgress", "(II)V", "GetOnImageUploadProgress_IIHandler:Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListenerInvoker, LiferayScreens_Android")]
		void OnImageUploadProgress (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liferay.mobile.screens.imagegallery']/interface[@name='ImageGalleryListener']/method[@name='onImageUploadStarted' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onImageUploadStarted", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListenerInvoker, LiferayScreens_Android")]
		void OnImageUploadStarted (global::Android.Net.Uri p0, string p1, string p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liferay.mobile.screens.imagegallery']/interface[@name='ImageGalleryListener']/method[@name='provideImageUploadDetailView' and count(parameter)=0]"
		[Register ("provideImageUploadDetailView", "()I", "GetProvideImageUploadDetailViewHandler:Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListenerInvoker, LiferayScreens_Android")]
		int ProvideImageUploadDetailView ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liferay.mobile.screens.imagegallery']/interface[@name='ImageGalleryListener']/method[@name='showUploadImageView' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int']]"
		[Register ("showUploadImageView", "(Ljava/lang/String;Landroid/net/Uri;I)Z", "GetShowUploadImageView_Ljava_lang_String_Landroid_net_Uri_IHandler:Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListenerInvoker, LiferayScreens_Android")]
		bool ShowUploadImageView (string p0, global::Android.Net.Uri p1, int p2);

	}

    [global::Android.Runtime.Register("com/liferay/mobile/screens/imagegallery/ImageGalleryListener", DoNotGenerateAcw = true)]
    internal class IImageGalleryListenerInvoker : global::Java.Lang.Object, IImageGalleryListener
    {

        static IntPtr java_class_ref = JNIEnv.FindClass("com/liferay/mobile/screens/imagegallery/ImageGalleryListener");

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(IImageGalleryListenerInvoker); }
        }

        IntPtr class_ref;

        public static IImageGalleryListener GetObject(IntPtr handle, JniHandleOwnership transfer)
        {
            return global::Java.Lang.Object.GetObject<IImageGalleryListener>(handle, transfer);
        }

        static IntPtr Validate(IntPtr handle)
        {
            if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                            JNIEnv.GetClassNameFromInstance(handle), "com.liferay.mobile.screens.imagegallery.ImageGalleryListener"));
            return handle;
        }

        protected override void Dispose(bool disposing)
        {
            if (this.class_ref != IntPtr.Zero)
                JNIEnv.DeleteGlobalRef(this.class_ref);
            this.class_ref = IntPtr.Zero;
            base.Dispose(disposing);
        }

        public IImageGalleryListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
        {
            IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
            this.class_ref = JNIEnv.NewGlobalRef(local_ref);
            JNIEnv.DeleteLocalRef(local_ref);
        }

        static Delegate cb_onImageEntryDeleted_J;
#pragma warning disable 0169
        static Delegate GetOnImageEntryDeleted_JHandler()
        {
            if (cb_onImageEntryDeleted_J == null)
                cb_onImageEntryDeleted_J = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, long>)n_OnImageEntryDeleted_J);
            return cb_onImageEntryDeleted_J;
        }

        static void n_OnImageEntryDeleted_J(IntPtr jnienv, IntPtr native__this, long p0)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.OnImageEntryDeleted(p0);
        }
#pragma warning restore 0169

        IntPtr id_onImageEntryDeleted_J;
        public unsafe void OnImageEntryDeleted(long p0)
        {
            if (id_onImageEntryDeleted_J == IntPtr.Zero)
                id_onImageEntryDeleted_J = JNIEnv.GetMethodID(class_ref, "onImageEntryDeleted", "(J)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(p0);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onImageEntryDeleted_J, __args);
        }

        static Delegate cb_onImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_;
#pragma warning disable 0169
        static Delegate GetOnImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_Handler()
        {
            if (cb_onImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_ == null)
                cb_onImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_);
            return cb_onImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_;
        }

        static void n_OnImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Liferay.Mobile.Screens.Imagegallery.Model.ImageEntry p0 = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.Model.ImageEntry>(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.OnImageUploadEnd(p0);
        }
#pragma warning restore 0169

        IntPtr id_onImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_;
        public unsafe void OnImageUploadEnd(global::Com.Liferay.Mobile.Screens.Imagegallery.Model.ImageEntry p0)
        {
            if (id_onImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_ == IntPtr.Zero)
                id_onImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_ = JNIEnv.GetMethodID(class_ref, "onImageUploadEnd", "(Lcom/liferay/mobile/screens/imagegallery/model/ImageEntry;)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(p0);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onImageUploadEnd_Lcom_liferay_mobile_screens_imagegallery_model_ImageEntry_, __args);
        }

        static Delegate cb_onImageUploadProgress_II;
#pragma warning disable 0169
        static Delegate GetOnImageUploadProgress_IIHandler()
        {
            if (cb_onImageUploadProgress_II == null)
                cb_onImageUploadProgress_II = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, int, int>)n_OnImageUploadProgress_II);
            return cb_onImageUploadProgress_II;
        }

        static void n_OnImageUploadProgress_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.OnImageUploadProgress(p0, p1);
        }
#pragma warning restore 0169

        IntPtr id_onImageUploadProgress_II;
        public unsafe void OnImageUploadProgress(int p0, int p1)
        {
            if (id_onImageUploadProgress_II == IntPtr.Zero)
                id_onImageUploadProgress_II = JNIEnv.GetMethodID(class_ref, "onImageUploadProgress", "(II)V");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(p0);
            __args[1] = new JValue(p1);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onImageUploadProgress_II, __args);
        }

        static Delegate cb_onImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetOnImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler()
        {
            if (cb_onImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
                cb_onImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_OnImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
            return cb_onImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
        }

        static void n_OnImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
            string p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
            string p2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
            string p3 = JNIEnv.GetString(native_p3, JniHandleOwnership.DoNotTransfer);
            __this.OnImageUploadStarted(p0, p1, p2, p3);
        }
#pragma warning restore 0169

        IntPtr id_onImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
        public unsafe void OnImageUploadStarted(global::Android.Net.Uri p0, string p1, string p2, string p3)
        {
            if (id_onImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
                id_onImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "onImageUploadStarted", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
            IntPtr native_p1 = JNIEnv.NewString(p1);
            IntPtr native_p2 = JNIEnv.NewString(p2);
            IntPtr native_p3 = JNIEnv.NewString(p3);
            JValue* __args = stackalloc JValue[4];
            __args[0] = new JValue(p0);
            __args[1] = new JValue(native_p1);
            __args[2] = new JValue(native_p2);
            __args[3] = new JValue(native_p3);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onImageUploadStarted_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
            JNIEnv.DeleteLocalRef(native_p1);
            JNIEnv.DeleteLocalRef(native_p2);
            JNIEnv.DeleteLocalRef(native_p3);
        }

        static Delegate cb_provideImageUploadDetailView;
#pragma warning disable 0169
        static Delegate GetProvideImageUploadDetailViewHandler()
        {
            if (cb_provideImageUploadDetailView == null)
                cb_provideImageUploadDetailView = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_ProvideImageUploadDetailView);
            return cb_provideImageUploadDetailView;
        }

        static int n_ProvideImageUploadDetailView(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.ProvideImageUploadDetailView();
        }
#pragma warning restore 0169

        IntPtr id_provideImageUploadDetailView;
        public unsafe int ProvideImageUploadDetailView()
        {
            if (id_provideImageUploadDetailView == IntPtr.Zero)
                id_provideImageUploadDetailView = JNIEnv.GetMethodID(class_ref, "provideImageUploadDetailView", "()I");
            return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_provideImageUploadDetailView);
        }

        static Delegate cb_showUploadImageView_Ljava_lang_String_Landroid_net_Uri_I;
#pragma warning disable 0169
        static Delegate GetShowUploadImageView_Ljava_lang_String_Landroid_net_Uri_IHandler()
        {
            if (cb_showUploadImageView_Ljava_lang_String_Landroid_net_Uri_I == null)
                cb_showUploadImageView_Ljava_lang_String_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>)n_ShowUploadImageView_Ljava_lang_String_Landroid_net_Uri_I);
            return cb_showUploadImageView_Ljava_lang_String_Landroid_net_Uri_I;
        }

        static bool n_ShowUploadImageView_Ljava_lang_String_Landroid_net_Uri_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            string p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
            global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri>(native_p1, JniHandleOwnership.DoNotTransfer);
            bool __ret = __this.ShowUploadImageView(p0, p1, p2);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_showUploadImageView_Ljava_lang_String_Landroid_net_Uri_I;
        public unsafe bool ShowUploadImageView(string p0, global::Android.Net.Uri p1, int p2)
        {
            if (id_showUploadImageView_Ljava_lang_String_Landroid_net_Uri_I == IntPtr.Zero)
                id_showUploadImageView_Ljava_lang_String_Landroid_net_Uri_I = JNIEnv.GetMethodID(class_ref, "showUploadImageView", "(Ljava/lang/String;Landroid/net/Uri;I)Z");
            IntPtr native_p0 = JNIEnv.NewString(p0);
            JValue* __args = stackalloc JValue[3];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(p2);
            bool __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_showUploadImageView_Ljava_lang_String_Landroid_net_Uri_I, __args);
            JNIEnv.DeleteLocalRef(native_p0);
            return __ret;
        }

        static Delegate cb_onListItemSelected_Ljava_lang_Object_Landroid_view_View_;
#pragma warning disable 0169
        static Delegate GetOnListItemSelected_Ljava_lang_Object_Landroid_view_View_Handler()
        {
            if (cb_onListItemSelected_Ljava_lang_Object_Landroid_view_View_ == null)
                cb_onListItemSelected_Ljava_lang_Object_Landroid_view_View_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_OnListItemSelected_Ljava_lang_Object_Landroid_view_View_);
            return cb_onListItemSelected_Ljava_lang_Object_Landroid_view_View_;
        }

        static void n_OnListItemSelected_Ljava_lang_Object_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
            global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_p1, JniHandleOwnership.DoNotTransfer);
            __this.OnListItemSelected(p0, p1);
        }
#pragma warning restore 0169

        IntPtr id_onListItemSelected_Ljava_lang_Object_Landroid_view_View_;
        public unsafe void OnListItemSelected(global::Java.Lang.Object p0, global::Android.Views.View p1)
        {
            if (id_onListItemSelected_Ljava_lang_Object_Landroid_view_View_ == IntPtr.Zero)
                id_onListItemSelected_Ljava_lang_Object_Landroid_view_View_ = JNIEnv.GetMethodID(class_ref, "onListItemSelected", "(Ljava/lang/Object;Landroid/view/View;)V");
            IntPtr native_p0 = JNIEnv.ToLocalJniHandle(p0);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(p1);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onListItemSelected_Ljava_lang_Object_Landroid_view_View_, __args);
            JNIEnv.DeleteLocalRef(native_p0);
        }

        static Delegate cb_onListPageFailed_ILjava_lang_Exception_;
#pragma warning disable 0169
        static Delegate GetOnListPageFailed_ILjava_lang_Exception_Handler()
        {
            if (cb_onListPageFailed_ILjava_lang_Exception_ == null)
                cb_onListPageFailed_ILjava_lang_Exception_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, int, IntPtr>)n_OnListPageFailed_ILjava_lang_Exception_);
            return cb_onListPageFailed_ILjava_lang_Exception_;
        }

        static void n_OnListPageFailed_ILjava_lang_Exception_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception>(native_p1, JniHandleOwnership.DoNotTransfer);
            __this.OnListPageFailed(p0, p1);
        }
#pragma warning restore 0169

        IntPtr id_onListPageFailed_ILjava_lang_Exception_;
        public unsafe void OnListPageFailed(int p0, global::Java.Lang.Exception p1)
        {
            if (id_onListPageFailed_ILjava_lang_Exception_ == IntPtr.Zero)
                id_onListPageFailed_ILjava_lang_Exception_ = JNIEnv.GetMethodID(class_ref, "onListPageFailed", "(ILjava/lang/Exception;)V");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(p0);
            __args[1] = new JValue(p1);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onListPageFailed_ILjava_lang_Exception_, __args);
        }

        static Delegate cb_onListPageReceived_IILjava_util_List_I;
#pragma warning disable 0169
        static Delegate GetOnListPageReceived_IILjava_util_List_IHandler()
        {
            if (cb_onListPageReceived_IILjava_util_List_I == null)
                cb_onListPageReceived_IILjava_util_List_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, int, int, IntPtr, int>)n_OnListPageReceived_IILjava_util_List_I);
            return cb_onListPageReceived_IILjava_util_List_I;
        }

        static void n_OnListPageReceived_IILjava_util_List_I(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, int p3)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p2 = global::Android.Runtime.JavaList.FromJniHandle(native_p2, JniHandleOwnership.DoNotTransfer);
            __this.OnListPageReceived(p0, p1, p2, p3);
        }
#pragma warning restore 0169

        IntPtr id_onListPageReceived_IILjava_util_List_I;
        public unsafe void OnListPageReceived(int p0, int p1, global::System.Collections.IList p2, int p3)
        {
            if (id_onListPageReceived_IILjava_util_List_I == IntPtr.Zero)
                id_onListPageReceived_IILjava_util_List_I = JNIEnv.GetMethodID(class_ref, "onListPageReceived", "(IILjava/util/List;I)V");
            IntPtr native_p2 = global::Android.Runtime.JavaList.ToLocalJniHandle(p2);
            JValue* __args = stackalloc JValue[4];
            __args[0] = new JValue(p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(native_p2);
            __args[3] = new JValue(p3);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onListPageReceived_IILjava_util_List_I, __args);
            JNIEnv.DeleteLocalRef(native_p2);
        }

        static Delegate cb_error_Ljava_lang_Exception_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetError_Ljava_lang_Exception_Ljava_lang_String_Handler()
        {
            if (cb_error_Ljava_lang_Exception_Ljava_lang_String_ == null)
                cb_error_Ljava_lang_Exception_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>)n_Error_Ljava_lang_Exception_Ljava_lang_String_);
            return cb_error_Ljava_lang_Exception_Ljava_lang_String_;
        }

        static void n_Error_Ljava_lang_Exception_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
        {
            global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener __this = global::Java.Lang.Object.GetObject<global::Com.Liferay.Mobile.Screens.Imagegallery.IImageGalleryListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception>(native_p0, JniHandleOwnership.DoNotTransfer);
            string p1 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
            __this.Error(p0, p1);
        }
#pragma warning restore 0169

        IntPtr id_error_Ljava_lang_Exception_Ljava_lang_String_;
        public unsafe void Error(global::Java.Lang.Exception p0, string p1)
        {
            if (id_error_Ljava_lang_Exception_Ljava_lang_String_ == IntPtr.Zero)
                id_error_Ljava_lang_Exception_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "error", "(Ljava/lang/Exception;Ljava/lang/String;)V");
            IntPtr native_p1 = JNIEnv.NewString(p1);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(p0);
            __args[1] = new JValue(native_p1);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_error_Ljava_lang_Exception_Ljava_lang_String_, __args);
            JNIEnv.DeleteLocalRef(native_p1);
        }

    }

}
