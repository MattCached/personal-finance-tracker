using System.Collections.ObjectModel;
using Personal_Finance_Tracker.Models;
using Personal_Finance_Tracker.Views;
using System.ComponentModel;
using System.Windows.Input;

namespace Personal_Finance_Tracker.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Transaction> Transactions { get; set; } = new ObservableCollection<Transaction>();
        public ICommand AddTransactionCommand { get; private set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainViewModel()
        {
            AddTransactionCommand = new RelayCommand(AddTransaction);
        }

        private void AddTransaction()
        {
            var addTransactionWindow = new AddTransactionWindow();
            if (addTransactionWindow.ShowDialog() == true)
            {
                Transactions.Add(addTransactionWindow.NewTransaction);
            }
        }
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
