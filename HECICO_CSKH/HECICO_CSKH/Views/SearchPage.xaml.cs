﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HECICO_CSKH.ViewModels.Search;
namespace HECICO_CSKH.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        SearchViewModel viewModel;
        public SearchPage()
        {
            InitializeComponent();
            viewModel = new SearchViewModel();
            viewModel.Navigation = Navigation;
            BindingContext = viewModel;
        }
    }
}