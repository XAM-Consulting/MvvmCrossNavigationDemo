using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;
using UIKit;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Xamarin.Forms;

namespace MvvmCrossNavigationDemo.iOS
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new Core.App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override IMvxTouchViewPresenter CreatePresenter ()
		{
			Forms.Init ();
			return new MvxFormsTouchPagePresenter (ApplicationDelegate ,Window);
		}
	}
}