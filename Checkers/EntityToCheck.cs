namespace Alert_and_Augmentor_POC
{
    public class EntityToCheck
    {
        public EntityToCheck(bool falseProperty, bool trueProperty, string deductedProperty)
        {
            FalseProperty = falseProperty;
            TrueProperty = trueProperty;
            DeductedProperty = deductedProperty;
        }

        public bool FalseProperty { get; }
        public bool TrueProperty { get; }
        
        public string DeductedProperty { get; }
        
    }
}