namespace Assessment_Device
{

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute : ValidateAttribute
    {
        public int Min { get; }
        public int Max { get; }

        public RangeAttribute(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public override string GetErrorMessage()
        {
            return ErrorMessage ?? $"Value must be between {Min} and {Max}.";
        }
    }
}

