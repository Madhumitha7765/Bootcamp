namespace Assessment_Device
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

        public Device(string id, int code, string description)
        {
            Id = id;
            Code = code;
            Description = description;
        }

        public string Id { get; private set; }

        public int Code { get; private set; }

        public string Description { get; private set; }
    }
}
