using System;
using Windows.UI.Xaml.Controls;

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
           return this._frame.Navigate(objective);
        }
    }
}