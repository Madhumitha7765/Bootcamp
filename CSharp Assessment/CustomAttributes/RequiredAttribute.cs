using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Device
{
    
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : ValidateAttribute
    {

        public override string GetErrorMessage()
        {
            return ErrorMessage ?? "This field is required.";
        }
    }
}
