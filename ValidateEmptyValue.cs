using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp2
{
    internal class ValidateEmptyValue : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo culture)
        {
            if (value.ToString() == "")
            {
                return new ValidationResult(false, "Wartosc nie moze byc pusta");
            }

            return new ValidationResult(true, null);
        }
    }
}
