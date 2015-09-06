using System;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.MvvmCross.ViewModels;
using Xamarin.Forms;
using UIKit;
using MvvmCrossNavigationDemo.Core;

namespace MvvmCrossNavigationDemo.iOS
{
	public class MvxFormsTouchPagePresenter : MvxTouchViewPresenter
	{

		public MvxFormsTouchPagePresenter (IUIApplicationDelegate applicationDelegate, UIWindow window) : base (applicationDelegate, window)
		{
		}

		public override void ChangePresentation (MvxPresentationHint hint)
		{
			this.MasterNavigationController.PopViewController (true);
		}

		public override void Show (MvxViewModelRequest request)
		{
			if (request.ViewModelType.FullName.Contains ("XamarinViewModel")) {

				var contentPage = MvxPresenterHelpers.CreatePage (request);
				//set DataContext of page to LoadViewModel
				var viewModel = MvxPresenterHelpers.LoadViewModel (request);

				contentPage.BindingContext = viewModel;
				//use CreateViewController 

				var uIViewController = contentPage.CreateViewController ();
				if (this.MasterNavigationController == null) {
					this.ShowFirstView (uIViewController);
				}
				else {
					this.MasterNavigationController.PushViewController (uIViewController, true);
				}

			} else
				base.Show (request);
		}
	}
}

