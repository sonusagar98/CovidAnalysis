using CovidAnalysis.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace CovidAnalysis.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        MainWindowViewModel viewModelInstance = new MainWindowViewModel();
        private void ComboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = viewModelInstance.Months;
            string currentMonth = DateTime.Today.ToString("MMMM");
            combo.SelectedIndex = viewModelInstance.Months.FindIndex(a => a.Contains(currentMonth));
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = sender as ComboBox;
            string selectedMonth = selectedItem.SelectedItem as string;
            viewModelInstance.LoadVaccinatonDataToDisplay(viewModelInstance.Months.FindIndex(a => a.Contains(selectedMonth)) + 1);
            //MessageBox.Show(selectedMonth);
        }
    }
}
