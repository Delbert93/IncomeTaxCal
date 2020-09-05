using IncomeTaxCal;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFIncome
{
    public class WPFViewModel : BindableBase
    {
        public WPFViewModel(RealFileProvider realFileProvider)
        {
            History = new ObservableCollection<IncomeTaxCalFinder>();

            //realFileProvider = new RealFileProvider();

            //this.fileProvider = fileProvider;

            IncomeCalculator = new IncomeTaxCalFinder();
            IncomeCalculator.Income = 75000;
            States = IncomeCalculator.taxRates;
            
            CalculateCommand = new DelegateCommand(() =>
            {
                if (IncomeCalculator.Income < 0)
                {
                    MessageBox.Show("Income must be greater the zero.");
                    return;
                }
                IncomeCalculator.State = SelectedState;
                if(IncomeCalculator.State == null)
                {
                    MessageBox.Show("A state must be selected");
                    return;
                }
                IncomeCalculator.taxableIncome();
                History.Add(IncomeCalculator);

                IncomeCalculator = IncomeCalculator.Clone() as IncomeTaxCalFinder;
                RaisePropertyChanged(nameof(IncomeCalculator));
            });
        }
        public IncomeTaxCalFinder IncomeCalculator { get; private set; }
        public DelegateCommand CalculateCommand { get; private set; }

        public ObservableCollection<IncomeTaxCalFinder> History { get; set; }

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

        //private bool isBusy;
        //public bool IsBusy
        //{
        //    get => isBusy;
        //    set
        //    {
        //        SetProperty(ref isBusy, value);
        //        ImportFromExcel.RaiseCanExecuteChanged();
        //    }
        //}

        //private DelegateCommand importFromExcel;
        //public DelegateCommand ImportFromExcel => importFromExcel ??= new DelegateCommand(
        //    async () =>
        //    {
        //        IsBusy = true;
        //        var rows = await fileProvider.ReadParametersFromExcelAsync(ImportFilePath);
        //        await Task.Run(() =>
        //        {
        //            Parallel.ForEach(rows, r => r.taxableIncome());
        //        });
        //        foreach (var r in rows)
        //        {
        //            History.Add(r);
        //        }
        //        IncomeCalculator = rows.Last().Clone() as IncomeTaxCalFinder;
        //        IsBusy = false;
        //    },
        //    () =>
        //    {
        //        return fileProvider.FileExists(ImportFilePath) && !IsBusy;
        //    }

        //);

        //private DelegateCommand exportToExcel;
        //public DelegateCommand ExportToExcel => exportToExcel ??= new DelegateCommand(
        //    () =>
        //    {
        //        fileProvider.ExportToExcel(History);
        //    },
        //    () =>
        //    {
        //        return History.Any();
        //    }
        //    );

        //private string importFilePath;
        //private readonly IFileProvider fileProvider;

        //public string ImportFilePath
        //{
        //    get => importFilePath;
        //    set
        //    {
        //        importFilePath = value;
        //        RaisePropertyChanged(nameof(ImportFilePath));
        //        ImportFromExcel.RaiseCanExecuteChanged();
        //    }
        //}

    }
}
