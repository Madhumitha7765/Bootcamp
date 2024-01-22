namespace ZeissObjectValidator
{
    using System;
    using System.ComponentModel.DataAnnotations;

    class Device
    {
        [Required(ErrorMessage = "ID Property Requires Value")]
        private string _id;

        [Range(10, 100, ErrorMessage = "Code Value Must Be Within 10-100")]
        private int _code;

        [MaxLength(100, ErrorMessage = "Max of 100 Characters are allowed")]
        private string _description;

        private string _barcode;

        public Device(string id, int code, string description, string barcode)
        {
            Id = id;
            Code = code;
            Description = description;
            BarCode = barcode;
        }

        public string Id { get; private set; }

        public int Code { get; private set; }

        public string Description { get; private set; }

        public string BarCode { get; private set; }
    }
}
