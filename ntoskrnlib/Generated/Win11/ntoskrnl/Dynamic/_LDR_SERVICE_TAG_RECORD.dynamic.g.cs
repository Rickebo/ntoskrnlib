using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LDR_SERVICE_TAG_RECORD")]
    public sealed class _LDR_SERVICE_TAG_RECORD : DynamicStructure
    {
        public IntPtr Next { get; }
        public uint ServiceTag { get; }

        public _LDR_SERVICE_TAG_RECORD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LDR_SERVICE_TAG_RECORD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LDR_SERVICE_TAG_RECORD.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LDR_SERVICE_TAG_RECORD.ServiceTag),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_LDR_SERVICE_TAG_RECORD>((mem, ptr) => new _LDR_SERVICE_TAG_RECORD(mem, ptr), offsets);
        }
    }
}