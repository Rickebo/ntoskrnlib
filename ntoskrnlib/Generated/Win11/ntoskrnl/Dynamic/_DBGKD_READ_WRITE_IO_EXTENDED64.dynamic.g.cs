using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_IO_EXTENDED64")]
    public sealed class _DBGKD_READ_WRITE_IO_EXTENDED64 : DynamicStructure
    {
        public uint DataSize { get; }
        public uint InterfaceType { get; }
        public uint BusNumber { get; }
        public uint AddressSpace { get; }
        public ulong IoAddress { get; }
        public uint DataValue { get; }

        public _DBGKD_READ_WRITE_IO_EXTENDED64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_READ_WRITE_IO_EXTENDED64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED64.DataSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED64.InterfaceType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED64.BusNumber),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED64.AddressSpace),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED64.IoAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED64.DataValue),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_DBGKD_READ_WRITE_IO_EXTENDED64>((mem, ptr) => new _DBGKD_READ_WRITE_IO_EXTENDED64(mem, ptr), offsets);
        }
    }
}