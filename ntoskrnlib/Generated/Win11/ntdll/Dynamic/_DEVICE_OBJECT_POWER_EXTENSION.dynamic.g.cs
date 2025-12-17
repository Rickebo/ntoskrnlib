using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_DEVICE_OBJECT_POWER_EXTENSION")]
    public sealed class _DEVICE_OBJECT_POWER_EXTENSION : DynamicStructure
    {
        public _DEVICE_OBJECT_POWER_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_OBJECT_POWER_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_DEVICE_OBJECT_POWER_EXTENSION>((mem, ptr) => new _DEVICE_OBJECT_POWER_EXTENSION(mem, ptr), offsets);
        }
    }
}