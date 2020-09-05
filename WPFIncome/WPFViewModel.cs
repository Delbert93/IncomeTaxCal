using IncomeTaxCal;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace WPFIncome
{
    public class WPFViewModel : BindableBase
    {
        public IncomeTaxCalFinder IncomeCalculator { get; private set; }
        public DelegateCommand CalculateCommand { get; private set; }
        public ObservableCollection<IncomeTaxCalFinder> History { get; set; }
        public WPFViewModel()
        {
            History = new ObservableCollection<IncomeTaxCalFinder>();

            IncomeCalculator = new IncomeTaxCalFinder();
            IncomeCalculator.Income = 75000;
            States = IncomeCalculator.taxRates;
            
            CalculateCommand = new DelegateCommand(() =>
            {
                IncomeCalculator.State = SelectedState;
                IncomeCalculator.taxableIncome();
                History.Add(IncomeCalculator);

                IncomeCalculator = IncomeCalculator.Clone() as IncomeTaxCalFinder;
                RaisePropertyChanged(nameof(IncomeCalculator));
            });
        }

        private Dictionary<string, decimal> states;
        public Dictionary<string, decimal> States
        {
            get { return states; }
            set
            {
                states = value;
            }
        }

        private string _selectedState;

        public string SelectedState
        {
            get { return _selectedState; }
            set
            {
                _selectedState = value;
            }
        }
    }
}
