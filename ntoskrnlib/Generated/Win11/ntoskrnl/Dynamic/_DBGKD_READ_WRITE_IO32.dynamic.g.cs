using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_IO32")]
    public sealed class _DBGKD_READ_WRITE_IO32 : DynamicStructure
    {
        public uint DataSize { get; }
        public uint IoAddress { get; }
        public uint DataValue { get; }

        public _DBGKD_READ_WRITE_IO32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_READ_WRITE_IO32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_READ_WRITE_IO32.DataSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO32.IoAddress),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO32.DataValue),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DBGKD_READ_WRITE_IO32>((mem, ptr) => new _DBGKD_READ_WRITE_IO32(mem, ptr), offsets);
        }
    }
}