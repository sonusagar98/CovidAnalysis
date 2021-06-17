using CovidAnalysis.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace CovidAnalysis.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ObservableCollection<VaccinationData> VaccinationData { get; set; }
        public ObservableCollection<VaccinationData> VaccinationDataToDisplay { get; set; }
        private string _title = "Prism Application";
        public List<string> Months { get; set; }
        public int currentMonth;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            Months = new List<string>();
            currentMonth = DateTime.Today.Month;
            VaccinationData = new ObservableCollection<VaccinationData>();
            VaccinationDataToDisplay = new ObservableCollection<VaccinationData>();
            LoadVaccinatonData();
            LoadVaccinatonDataToDisplay(currentMonth);
            ExtractMonths();
        }



        public void ExtractMonths()
        {
            Dictionary<int, string> monthDictionary = new Dictionary<int, string>();
            monthDictionary.Add(1, "January");
            monthDictionary.Add(2, "February");
            monthDictionary.Add(3, "March");
            monthDictionary.Add(4, "April");
            monthDictionary.Add(5, "May");
            monthDictionary.Add(6, "June");
            monthDictionary.Add(7, "July");
            monthDictionary.Add(8, "August");
            monthDictionary.Add(9, "September");
            monthDictionary.Add(10, "October");
            monthDictionary.Add(11, "November");
            monthDictionary.Add(12, "December");

            foreach (var data in VaccinationData)
            {
                int monthIndex = data.DateTime.Month;
                if(!Months.Contains(monthDictionary[monthIndex]))
                    Months.Add(monthDictionary[monthIndex]);
            }
        }
        public void LoadVaccinatonData()
        {
            string filename = "vaccinationData";
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(filename, ".csv"));
            foreach (var line in lines)
            {
                string[] data = line.Split(',');
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "")
                    {
                        data[i] = "0";
                    }
                }
                VaccinationData vaccination = new VaccinationData(data[0], data[1], Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), Convert.ToInt32(data[4]), Convert.ToInt32(data[5]), Convert.ToInt32(data[6]), Convert.ToInt32(data[7]), Convert.ToInt32(data[8]));
                VaccinationData.Add(vaccination);
            }
        }
        public void LoadVaccinatonDataToDisplay(int month)
        {
            VaccinationDataToDisplay.Clear();
            foreach(var data in VaccinationData)
            {
                if(data.DateTime.Month==month)
                {
                     VaccinationDataToDisplay.Add(data);
                }
            }
        }
    }
}
