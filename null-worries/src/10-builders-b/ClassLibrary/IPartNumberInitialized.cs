namespace NullWorries
{
    public interface IPartNumberInitialized : IDescriptionInitialized
    {
        IDescriptionInitialized Description(string description);
    }
}
