using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Views;

namespace MvvmCrossNavigationDemo.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

		protected override void InitializeFirstChance ()
		{
			base.InitializeFirstChance ();
			Mvx.RegisterSingleton<IMvxViewPresenter>(new MvxFormsDroidPagePresenter());
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override IMvxAndroidViewPresenter CreateViewPresenter ()
		{
			return Mvx.Resolve<IMvxViewPresenter>() as MvxFormsDroidPagePresenter;
		}
    }
}