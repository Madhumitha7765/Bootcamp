using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Device
{

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public abstract class ValidateAttribute : Attribute
    {
        public string ErrorMessage { get; set; }

        public abstract string GetErrorMessage();
    }
}
