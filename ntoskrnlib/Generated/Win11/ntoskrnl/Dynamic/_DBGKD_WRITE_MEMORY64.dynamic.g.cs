using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_WRITE_MEMORY64")]
    public sealed class _DBGKD_WRITE_MEMORY64 : DynamicStructure
    {
        public ulong TargetBaseAddress { get; }
        public uint TransferCount { get; }
        public uint ActualBytesWritten { get; }

        public _DBGKD_WRITE_MEMORY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_WRITE_MEMORY64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_WRITE_MEMORY64.TargetBaseAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_WRITE_MEMORY64.TransferCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_WRITE_MEMORY64.ActualBytesWritten),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_DBGKD_WRITE_MEMORY64>((mem, ptr) => new _DBGKD_WRITE_MEMORY64(mem, ptr), offsets);
        }
    }
}