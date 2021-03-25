﻿using HECICO_CSKH.ViewModels.Notitication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HECICO_CSKH.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationPage : ContentPage
    {
        NotificationViewModel viewModel;
        public NotificationPage()
        {
            InitializeComponent();
            viewModel = new NotificationViewModel();
            viewModel.Navigation = Navigation;
            BindingContext = viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.LoadCommand.Execute(null);
        }
    }
}