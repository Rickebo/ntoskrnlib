using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_MEMORY32")]
    public sealed class _DBGKD_READ_MEMORY32 : DynamicStructure
    {
        public uint TargetBaseAddress { get; }
        public uint TransferCount { get; }
        public uint ActualBytesRead { get; }

        public _DBGKD_READ_MEMORY32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_READ_MEMORY32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_READ_MEMORY32.TargetBaseAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_READ_MEMORY32.TransferCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_READ_MEMORY32.ActualBytesRead),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DBGKD_READ_MEMORY32>((mem, ptr) => new _DBGKD_READ_MEMORY32(mem, ptr), offsets);
        }
    }
}