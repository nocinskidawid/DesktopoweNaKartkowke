using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp2
{
    internal class ValidatePesel : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo culture)
        {
            if (value.ToString().Length != 11)
            {
                return new ValidationResult(false, "Niepoprawna ilosc znakow");
            }

            return new ValidationResult(true, null);
        }
    }
}
