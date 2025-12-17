using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MAP_REGISTER_ENTRY")]
    public sealed class _MAP_REGISTER_ENTRY : DynamicStructure
    {
        public IntPtr MapRegister { get; }
        public byte WriteToDevice { get; }

        public _MAP_REGISTER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MAP_REGISTER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MAP_REGISTER_ENTRY.MapRegister),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MAP_REGISTER_ENTRY.WriteToDevice),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MAP_REGISTER_ENTRY>((mem, ptr) => new _MAP_REGISTER_ENTRY(mem, ptr), offsets);
        }
    }
}