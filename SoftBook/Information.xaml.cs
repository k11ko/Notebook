﻿using System;
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

namespace SoftBook
{
	/// <summary>
	/// Логика взаимодействия для Information.xaml
	/// </summary>
	public partial class Information : Window
	{
		public Information()
		{
			InitializeComponent();
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
