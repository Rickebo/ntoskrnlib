using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_IO64")]
    public sealed class _DBGKD_READ_WRITE_IO64 : DynamicStructure
    {
        public ulong IoAddress { get; }
        public uint DataSize { get; }
        public uint DataValue { get; }

        public _DBGKD_READ_WRITE_IO64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_READ_WRITE_IO64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_READ_WRITE_IO64.IoAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO64.DataSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO64.DataValue),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_DBGKD_READ_WRITE_IO64>((mem, ptr) => new _DBGKD_READ_WRITE_IO64(mem, ptr), offsets);
        }
    }
}