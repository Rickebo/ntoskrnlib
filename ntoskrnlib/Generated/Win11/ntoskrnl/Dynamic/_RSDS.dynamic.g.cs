using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RSDS")]
    public sealed class _RSDS : DynamicStructure
    {
        public uint Signature { get; }
        public _GUID Guid { get; }
        public uint Age { get; }
        public sbyte[] PdbName { get; }

        public _RSDS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RSDS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RSDS.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RSDS.Guid),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RSDS.Age),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_RSDS.PdbName),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_RSDS>((mem, ptr) => new _RSDS(mem, ptr), offsets);
        }
    }
}