using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LEAP_SECOND_DATA")]
    public sealed class _LEAP_SECOND_DATA : DynamicStructure
    {
        public byte Enabled { get; }
        public uint Count { get; }
        public byte[] Data { get; }

        public _LEAP_SECOND_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LEAP_SECOND_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LEAP_SECOND_DATA.Enabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LEAP_SECOND_DATA.Count),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LEAP_SECOND_DATA.Data),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_LEAP_SECOND_DATA>((mem, ptr) => new _LEAP_SECOND_DATA(mem, ptr), offsets);
        }
    }
}