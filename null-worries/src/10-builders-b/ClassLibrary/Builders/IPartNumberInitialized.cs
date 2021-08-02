namespace NullWorries.Builders
{
    public interface IPartNumberInitialized : IDescriptionInitialized
    {
        IDescriptionInitialized Description(string description);
    }
}
