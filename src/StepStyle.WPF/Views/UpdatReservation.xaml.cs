﻿using StepStyle.WPF.ViewModels;
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
    /// Interaction logic for UpdatReservation.xaml
    /// </summary>
    public partial class UpdatReservation : UserControl, ILeftMenuView
    {
        public UpdatReservation(UpdateReservation update)
        {
            InitializeComponent();
            DataContext = update;
        }

        public string Title => "Редактирование брони";
    }
}
