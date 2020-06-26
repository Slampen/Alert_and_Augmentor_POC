namespace Alert_and_Augmentor_POC
{
    public class AugmentedValue
    {
        public AugmentedValue(string fieldName, object value, string userReadableString)
        {
            FieldName = fieldName;
            Value = value;
            UserReadableString = userReadableString;
        }

        public string FieldName { get; }
        public object Value { get; }
        public string UserReadableString { get; }

        public string PropertyPath { get; private set; }
        
        public AccuracyEnum Accuracy { get; private set; }
    }
}