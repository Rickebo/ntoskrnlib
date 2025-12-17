using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_IO_EXTENDED32")]
    public sealed class _DBGKD_READ_WRITE_IO_EXTENDED32 : DynamicStructure
    {
        public uint DataSize { get; }
        public uint InterfaceType { get; }
        public uint BusNumber { get; }
        public uint AddressSpace { get; }
        public uint IoAddress { get; }
        public uint DataValue { get; }

        public _DBGKD_READ_WRITE_IO_EXTENDED32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_READ_WRITE_IO_EXTENDED32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED32.DataSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED32.InterfaceType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED32.BusNumber),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED32.AddressSpace),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED32.IoAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_IO_EXTENDED32.DataValue),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_DBGKD_READ_WRITE_IO_EXTENDED32>((mem, ptr) => new _DBGKD_READ_WRITE_IO_EXTENDED32(mem, ptr), offsets);
        }
    }
}