using Crystal_Ideas_Desktop.Models;
using Crystal_Ideas_Desktop.Services;
using Crystal_Ideas_Desktop.ViewModels;
using Crystal_Ideas_Desktop.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


namespace Crystal_Ideas_Desktop
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        private Frame frame = new Frame();
        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public static IServiceProvider Services { get; set; }

        /// <summary>
        public App()
        {
         
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        private ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<SecurityView>();
            services.AddSingleton<RegisterProfileView>();
            services.AddSingleton<ISecurityViewModel, SecurityViewModel>();
            services.AddSingleton<ISecurityModel, SecurityModel>();
            services.AddSingleton<INavigationService>(new NavigationService(this.frame));
            services.AddSingleton<IRegisterProfileViewModel, RegisterProfileViewModel>();
            services.AddSingleton<IRegisterProfileModel, RegisterProfileModel>();

            return services.BuildServiceProvider();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            this.frame = Window.Current.Content as Frame;
         
            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (this.frame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                this.frame = new Frame();

                this.frame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = this.frame;

            }
            Services = this.ConfigureServices();

            if (e.PrelaunchActivated == false)
            {
                if (this.frame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    this.frame.Content = Services.GetRequiredService(typeof(SecurityView));
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
