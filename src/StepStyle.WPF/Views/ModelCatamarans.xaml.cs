﻿using Microsoft.EntityFrameworkCore;
using StepStyle.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StepStyle.WPF.Views
{
    /// <summary>
    /// Interaction logic for ModelCatamarans.xaml
    /// </summary>
    public partial class ModelCatamarans : Window
    {
        public ModelCatamarans(CatamaranViewModel catamaranView)
        {
            InitializeComponent();
            DataContext = catamaranView;
            catamaranView.OnRequestClose += (s, e) => Hide();
        }

    }
}
