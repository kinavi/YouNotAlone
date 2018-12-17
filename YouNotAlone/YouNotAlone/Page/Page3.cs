﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace YouNotAlone.Page
{
    public class Page3 : ContentPage
    {
        Label stackLabel;
        public Page3()
        {
            Title = "Page 3";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;

            stackLabel = new Label();
            Content = new StackLayout { Children = { backBtn, stackLabel } };
        }
        protected internal void DisplayStack()
        {
            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            stackLabel.Text = "";
            foreach (Xamarin.Forms.Page p in navPage.Navigation.NavigationStack)
            {
                stackLabel.Text += p.Title + "\n";
            }
        }
        // Переход обратно на Page2
        private async void GoToBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            NavigationPage navPage = (NavigationPage)App.Current.MainPage;
            ((Page2)navPage.CurrentPage).DisplayStack();
        }
    }
}