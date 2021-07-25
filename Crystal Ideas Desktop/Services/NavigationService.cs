using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Crystal_Ideas_Desktop.Views;

namespace Crystal_Ideas_Desktop.Services
{
    internal class NavigationService : INavigationService
    {
        private readonly Frame _frame;

        public NavigationService(Frame frame)
        {
            _frame = frame;
        }

        public bool NavigateTo(Type objective)
        {
            try
            {
                this._frame.Content = App.Services.GetService(objective);
                Window.Current.Content = (Page) this._frame.Content;
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}