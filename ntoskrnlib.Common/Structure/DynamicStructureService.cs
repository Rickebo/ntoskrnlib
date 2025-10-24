using System;
using System.Collections.Generic;

namespace ntoskrnlib.Structure
{
    // Lightweight façade over DynamicStructure’s registry to avoid reflection-heavy scans.
    // Classes register themselves via a static ctor calling DynamicStructure.Register<T>(ctor).
    public sealed class DynamicStructureService
    {
        private readonly IMemorySource _memory;

        public DynamicStructureService(IMemorySource memory) => _memory = memory;

        // Reads a dynamic structure instance at the given address if T was registered.
        public T Read<T>(MemoryPointer address) where T : DynamicStructure =>
            DynamicStructure.Construct<T>(_memory, address);

        // Convenience registration forwarder (optional to use from tests/helpers)
        public static void Register<T>(Func<IMemorySource, MemoryPointer, T> ctor)
            where T : DynamicStructure => DynamicStructure.Register(ctor);

        public static void Register<T>(Func<IMemorySource, MemoryPointer, T> ctor,
                                       IDictionary<string, ulong[]> offsets)
            where T : DynamicStructure => DynamicStructure.Register(ctor, offsets);
    }
}
