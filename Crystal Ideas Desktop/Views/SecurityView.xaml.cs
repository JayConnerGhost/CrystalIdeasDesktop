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
using Crystal_Ideas_Desktop.ViewModels;
using Microsoft.Extensions.DependencyInjection;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Crystal_Ideas_Desktop.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecurityView : Page
    {
        private readonly ISecurityViewModel _viewModel;

        public SecurityView()
        {
            _viewModel = App.Current.Services.GetService<ISecurityViewModel>();
            this.DataContext = _viewModel;
            this.InitializeComponent();
        }
    }
}
