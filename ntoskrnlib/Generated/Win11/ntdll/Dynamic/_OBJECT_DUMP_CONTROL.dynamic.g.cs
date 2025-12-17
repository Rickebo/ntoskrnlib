using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_OBJECT_DUMP_CONTROL")]
    public sealed class _OBJECT_DUMP_CONTROL : DynamicStructure
    {
        public IntPtr Stream { get; }
        public uint Detail { get; }

        public _OBJECT_DUMP_CONTROL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_DUMP_CONTROL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_DUMP_CONTROL.Stream),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_DUMP_CONTROL.Detail),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OBJECT_DUMP_CONTROL>((mem, ptr) => new _OBJECT_DUMP_CONTROL(mem, ptr), offsets);
        }
    }
}