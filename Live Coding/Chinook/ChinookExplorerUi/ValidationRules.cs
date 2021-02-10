using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace ChinookExplorerUi
{
    public class StringLengthValidationRule : ValidationRule
    {
        public StringLengthValidationRule()
        {

        }

        public StringLengthValidationRule(int minLength, int maxLength)
        {
            this.MinLength = minLength;
            this.MaxLength = maxLength;
        }

        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string text = value?.ToString();

            if (string.IsNullOrWhiteSpace(text) || text.Length < MinLength || text.Length > MaxLength)
            {
                return new ValidationResult(false, $"Länge muss zwischen {this.MinLength:#,##0} und {this.MaxLength:#,##0} liegen.");
            }

            return new ValidationResult(true, "");
        }
    }

    public class IntegerInRangeValidationRule : ValidationRule
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (Int32.TryParse(value?.ToString(), out int number))
            {
                number = Convert.ToInt32(value, cultureInfo);

                if (number >= Minimum && number <= Maximum)
                {
                    return new ValidationResult(true, "");
                }
            }

            return new ValidationResult(false, $"Zahl ausserhalb des gg. Bereichs ({Minimum:#,##0}..{Maximum:#,##0})!");
        }
    }
}
