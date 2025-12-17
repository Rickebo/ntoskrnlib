using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOP_IRP_EXTENSION_STATUS")]
    public sealed class _IOP_IRP_EXTENSION_STATUS : DynamicStructure
    {
        public uint Flags { get; }
        public uint ActivityId { get; }
        public uint IoTracking { get; }

        public _IOP_IRP_EXTENSION_STATUS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOP_IRP_EXTENSION_STATUS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOP_IRP_EXTENSION_STATUS.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION_STATUS.ActivityId),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IOP_IRP_EXTENSION_STATUS.IoTracking),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IOP_IRP_EXTENSION_STATUS>((mem, ptr) => new _IOP_IRP_EXTENSION_STATUS(mem, ptr), offsets);
        }
    }
}