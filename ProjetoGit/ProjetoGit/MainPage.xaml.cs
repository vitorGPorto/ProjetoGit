﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoGit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            entToken.Text = "teste token";
           // BindingContext = new MyBindableObject();

        }

        private void Image_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
