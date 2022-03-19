using Leonov_PR14.ViewModels;
using Leonov_PR14.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Leonov_PR14
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
