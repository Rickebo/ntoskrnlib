using System;

namespace ntoskrnlib.Structure
{
    public interface IMemorySource
    {
        T Read<T>(MemoryPointer address) where T : struct;
        void Write<T>(MemoryPointer address, T value) where T : struct;
    }
}

namespace ntoskrnlib.Structure
{
    public static class MemorySourceExtensions
    {
        public static T ReadStructure<T>(this IMemorySource memory, MemoryPointer address)
            where T : DynamicStructure
        {
            return address.IsValid()
                ? DynamicStructure.Construct<T>(memory, address)
                : null;
        }
    }
}
