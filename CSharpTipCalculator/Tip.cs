using System;
using System.Globalization;

namespace CSharpTipCalculator {
    class Tip {
        public string BillAmount { get; set; }
        public string TipAmount { get; set; }
        public string TotalAmount { get; set; }
        public Tip() {
            BillAmount = TipAmount = TotalAmount = String.Empty;
        }
        public void CalculateTip(string originalAmount, decimal tipPercentage) {
            var billAmount = 0.0m;
            var tipAmount = 0.0m;
            var totalAmount = 0.0m;
            if (decimal.TryParse(originalAmount.Replace('$', ' '), out billAmount)) {
                tipAmount = billAmount * tipPercentage;
                totalAmount = billAmount + tipAmount;
            }
            IFormatProvider provider = CultureInfo.GetCultureInfoByIetfLanguageTag("en-US");
            BillAmount = String.Format(provider, "{0:C}", billAmount);
            TipAmount = String.Format(provider, "{0:C}", tipAmount);
            TotalAmount = String.Format(provider, "{0:C}", totalAmount);
        }
    }
}
