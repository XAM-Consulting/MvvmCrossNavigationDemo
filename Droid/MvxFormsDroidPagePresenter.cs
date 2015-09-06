using System;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using MvvmCrossNavigationDemo.Core;

namespace MvvmCrossNavigationDemo.Droid
{
	public class MvxFormsDroidPagePresenter : MvxAndroidViewPresenter, IMvxAndroidViewPresenter
	{
		Stack<MvxViewModelRequest> _navigationStack = new Stack<MvxViewModelRequest>();

		public MvxFormsDroidPagePresenter()
		{
		}

		public override void ChangePresentation (MvxPresentationHint hint)
		{
			_navigationStack.Pop();
			var request = _navigationStack.Pop();
			this.Show (request);
		}

		public override void Show (MvxViewModelRequest request)
		{
			if (request.ViewModelType.FullName.Contains ("XamarinViewModel")) {

				var contentPage = MvxPresenterHelpers.CreatePage (request);
				//set DataContext of page to LoadViewModel
				var viewModel = MvxPresenterHelpers.LoadViewModel (request);

				contentPage.BindingContext = viewModel;

				MvxFormsApplicationActivity.CurrentPage = contentPage;
				this.Activity.StartActivity(typeof(MvxFormsApplicationActivity));

			} else {
				base.Show (request);
			}
			_navigationStack.Push (request);
		}
	}

}

