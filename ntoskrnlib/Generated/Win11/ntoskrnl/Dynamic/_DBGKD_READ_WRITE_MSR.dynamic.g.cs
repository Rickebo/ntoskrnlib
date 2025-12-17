using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_READ_WRITE_MSR")]
    public sealed class _DBGKD_READ_WRITE_MSR : DynamicStructure
    {
        public uint Msr { get; }
        public uint DataValueLow { get; }
        public uint DataValueHigh { get; }

        public _DBGKD_READ_WRITE_MSR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_READ_WRITE_MSR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_READ_WRITE_MSR.Msr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_MSR.DataValueLow),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_READ_WRITE_MSR.DataValueHigh),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DBGKD_READ_WRITE_MSR>((mem, ptr) => new _DBGKD_READ_WRITE_MSR(mem, ptr), offsets);
        }
    }
}