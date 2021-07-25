using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Crystal_Ideas_Desktop.Services;
using Crystal_Ideas_Desktop.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Crystal_Ideas_Desktop.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecurityView : Page
    {
        private readonly INavigationService _navigationService;
        private readonly ISecurityViewModel ViewModel;

        public SecurityView(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ViewModel = App.Current.Services.GetService<ISecurityViewModel>();
            this.DataContext = ViewModel;
            this.InitializeComponent();
            LoadMessenger();
        }

        private void LoadMessenger()
        {
            // Register a message in some module
            WeakReferenceMessenger.Default.Register<DisplayRegisterUserMessage>(this, (r, m) =>
            {
              //this._navigationService.NavigateTo(typeof(""))
            });
        }
    }
}
