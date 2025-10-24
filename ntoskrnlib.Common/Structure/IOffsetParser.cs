namespace ntoskrnlib.Structure
{
    public interface IOffsetParser
    {
        ulong[] Parse(params string[] keys);
    }
}
