using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CSharpTipCalculator {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        private Tip tip;
        public MainWindow() {
            InitializeComponent();
            tip = new Tip();
        }

        private void billAmountTextBox_LostFocus(object sender, RoutedEventArgs e) {
            billAmountTextBox.Text = tip.BillAmount;
        }

        private void billAmountTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            performCalculation();
        }

        private void billAmountTextBox_GotFocus(object sender, RoutedEventArgs e) {
            billAmountTextBox.Text = String.Empty;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e) {
            performCalculation();
        }

        private void performCalculation() {
            var selectedRadio = myStackPanel.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked ?? false);
            if (selectedRadio == null) return;
            tip.CalculateTip(billAmountTextBox.Text, decimal.Parse(selectedRadio.Tag.ToString()));
            amountToTipTextBlock.Text = tip.TipAmount;
            totalTextBlock.Text = tip.TotalAmount;
        }
    }
}
