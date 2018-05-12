using System;
using System.Globalization;
using System.Windows.Controls;

namespace WPFLecture.Models.Validation
{
    public class NumberRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo ci)
        {
            string input = value as string;

            if(String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
                return new ValidationResult(false, "Empty string");

            int result;
            var status = int.TryParse(input, NumberStyles.Any,
                                      CultureInfo.InvariantCulture, out result);

            return status ? ValidationResult.ValidResult
                          : new ValidationResult(false, input + " is not a number");
        }
    }
}
