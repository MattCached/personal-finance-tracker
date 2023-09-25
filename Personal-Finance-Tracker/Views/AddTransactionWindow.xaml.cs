using System;
using System.Runtime.InteropServices.JavaScript;
using System.Windows;
using Personal_Finance_Tracker.Models;

namespace Personal_Finance_Tracker.Views;

public partial class AddTransactionWindow : Window
{
 
    public Transaction NewTransaction { get; private set; }
    
    public AddTransactionWindow()
    {
        InitializeComponent();
    }

    private void OnAddTransactionClick(object sender, RoutedEventArgs e)
    {
        DateTime date = DateInput.SelectedDate.Value;
        string description = DescriptionInput.Text;
        decimal amount = Decimal.Parse(AmountInput.Text);
        string category = CategoryInput.Text;

        if (DateInput.SelectedDate == null ||
            string.IsNullOrWhiteSpace(DescriptionInput.Text) ||
            !decimal.TryParse(AmountInput.Text, out amount) ||
            string.IsNullOrWhiteSpace(CategoryInput.Text))
        {
            MessageBox.Show("Please fill in all fields correctly.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        NewTransaction = new Transaction(date, description, amount, category);
        

        DialogResult = true;
        Close();
    }
}