MvvmCross Navigation Demo
===============================
This project is demo for using MvvmCross navigate between native page and Xamarin Forms page

###For this demo, some steps are import.

1. Included Xamarin.Forms packages into IOS and Android Project
2. Init Xamarin.Forms, for IOS, it is in Setup.cs. But in Android, it is in SplashScreen page, if your project doesn’t have that page, you should make sure Xamarin.Forms.Init() before show Xamarin Forms page.
3. Copy MvxTouchViewPresenter MvxPresenterHelpers MvxFormsDroidPagePresenter pages into your project. For Android project, you need create MvxFormsApplicationActivity, because Xamarin Forms need a host activity in Android.