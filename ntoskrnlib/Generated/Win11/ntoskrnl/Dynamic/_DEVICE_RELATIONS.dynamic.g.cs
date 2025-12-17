using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_RELATIONS")]
    public sealed class _DEVICE_RELATIONS : DynamicStructure
    {
        public uint Count { get; }
        public byte[] Objects { get; }

        public _DEVICE_RELATIONS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_RELATIONS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_RELATIONS.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_RELATIONS.Objects),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DEVICE_RELATIONS>((mem, ptr) => new _DEVICE_RELATIONS(mem, ptr), offsets);
        }
    }
}