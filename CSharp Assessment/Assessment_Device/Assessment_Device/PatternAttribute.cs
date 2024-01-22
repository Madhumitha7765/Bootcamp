namespace Assessment_Device
{
    using Assessment_Device;
    using System;
    using System.Text.RegularExpressions;

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class ValidateBarcodeAttribute : ValidateAttribute
    {
        private const string BarcodePattern = @"^Z\d{12}$";

        public bool Validate(object value)
        {
            if (value is string barcode)
            {
                // Use regex to validate the barcode format.
                return Regex.IsMatch(barcode, BarcodePattern);
            }

            return false;
        }

        public override string IsValid()
        {
            return ErrorMessage ?? "Invalid barcode format. It must begin with 'Z' and be followed by 12 digits.";
        }
    }
}
