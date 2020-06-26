namespace Alert_and_Augmentor_POC
{
    public enum AccuracyEnum
    {
        MustBe = 1,     // Based on other values, the augmented field must be the result given.
        ShouldBe = 2,   // Based on other values, it is highly likly (but in some cases is not) the augmented value
        IsMostLikly = 3 // Given nothing else is known, the returned augmented value is most likly correct.
    }
}