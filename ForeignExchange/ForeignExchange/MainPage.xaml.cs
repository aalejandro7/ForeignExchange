﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForeignExchange
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();

            ConvertButton.Clicked += ConvertButton_Clicked;
            

        }

        void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PesosEntry.Text))
            {
                DisplayAlert("Error", "Your must enter a value in pesos...", "Accept");
                return;
            }

            decimal pesos = 0;
            if (!decimal.TryParse(PesosEntry.Text, out pesos))
            {
                DisplayAlert("Error", "Your must enter a value numeric in pesos...", "Accept");
                return;
            }

            var dollars = pesos / 3003.003M;
            var euros = pesos / 3531.051M;
            var pounds = pesos / 3907.237M;

            DollarsEntry.Text = string.Format("${0:N2}", dollars);
            EurosEntry.Text = string.Format("€{0:N2}", euros);
            PoundsEntry.Text = string.Format("£{0:N2}", pounds);
            
        }
    }
}
