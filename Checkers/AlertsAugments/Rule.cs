namespace Alert_and_Augmentor_POC
{
    internal class Rule : IRule
    {
       

        public void CheckMe(EntityToCheck t)
        {
            var checkResult = new RuleResult();

            if (t.FalseProperty == false)
            {
            }


            //return checkResult;
        }

        public AugmentedValue AugmentedResult { get; }
        
        public RuleResult RuleResult { get; }

        public Severity Severity => Severity.Warning;
    }
}