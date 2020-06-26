namespace Alert_and_Augmentor_POC
{
    public interface IRule
    {
        void CheckMe(EntityToCheck t);
        
        RuleResult RuleResult { get; }
        
        Severity Severity { get; }
        
        public AugmentedValue AugmentedResult { get; }
        
    }
}