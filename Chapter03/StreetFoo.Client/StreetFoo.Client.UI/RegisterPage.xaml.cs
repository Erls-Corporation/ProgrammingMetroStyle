﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TinyIoC;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace StreetFoo.Client.UI
{
    [ViewModel(typeof(IRegisterPageViewModel))]
    public sealed partial class RegisterPage : StreetFoo.Client.UI.Common.LayoutAwarePage
    {
        public RegisterPage()
        {
            this.InitializeComponent();

            // obtain a real instance of a model... now done by dependency injection...
            this.InitializeModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        //private void HandleRegisterClick(object sender, RoutedEventArgs e)
        //{
        //    // ask the model to handle this... pass in callbacks for success, and a general callback for
        //    // failure...
        //    this.Model.DoRegistration((result) =>
        //    {
        //        this.ShowAlertAsync("Great - we got a result back.");  

        //    }, this.FailureSink);
        //}

        //private void FailureSink(ErrorBucket bucket, object callbackArgs)
        //{
        //    this.ShowAlertAsync(bucket);
        //}

    }
}
