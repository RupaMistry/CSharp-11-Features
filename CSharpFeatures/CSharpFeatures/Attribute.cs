namespace System.Runtime.CompilerServices;

public class RequiredMemberAttribute : Attribute { }
public class CompilerFeatureRequiredAttribute : Attribute
{
    public CompilerFeatureRequiredAttribute(string name) { }
}

public sealed class SetsRequiredMembersAttribute : Attribute { }