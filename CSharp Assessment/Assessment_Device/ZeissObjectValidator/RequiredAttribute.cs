using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeissObjectValidator
{
    
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : ValidateAttribute
    {

        public override string IsValid()
        {
            return ErrorMessage ?? "This field is required.";
        }
    }
}
