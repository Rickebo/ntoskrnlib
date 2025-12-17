using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_SET_BUS_DATA")]
    public sealed class _DBGKD_GET_SET_BUS_DATA : DynamicStructure
    {
        public uint BusDataType { get; }
        public uint BusNumber { get; }
        public uint SlotNumber { get; }
        public uint Offset { get; }
        public uint Length { get; }

        public _DBGKD_GET_SET_BUS_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_GET_SET_BUS_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_GET_SET_BUS_DATA.BusDataType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_GET_SET_BUS_DATA.BusNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_GET_SET_BUS_DATA.SlotNumber),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_GET_SET_BUS_DATA.Offset),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DBGKD_GET_SET_BUS_DATA.Length),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DBGKD_GET_SET_BUS_DATA>((mem, ptr) => new _DBGKD_GET_SET_BUS_DATA(mem, ptr), offsets);
        }
    }
}