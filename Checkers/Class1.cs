using System;

namespace Alert_and_Augmentor_POC
{
    
    public interface IRule
    {
        CheckResult CheckMe(CheckEntity t);
        Severity Severity { get; }
    }

    public class CheckResult
    {
    }

    public class CheckEntity
    {
    }
    
    public enum Severity
    {
        Error = 1
        , Warning = 2
        , DataValidationOnly = 3
    }
}