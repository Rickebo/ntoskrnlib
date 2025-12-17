using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_MANIPULATE_STATE64")]
    public sealed class _DBGKD_MANIPULATE_STATE64 : DynamicStructure
    {
        public uint ApiNumber { get; }
        public ushort ProcessorLevel { get; }
        public ushort Processor { get; }
        public int ReturnStatus { get; }
        public _unnamed_tag_ u { get; }

        public _DBGKD_MANIPULATE_STATE64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_MANIPULATE_STATE64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_MANIPULATE_STATE64.ApiNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_MANIPULATE_STATE64.ProcessorLevel),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_MANIPULATE_STATE64.Processor),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_DBGKD_MANIPULATE_STATE64.ReturnStatus),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_MANIPULATE_STATE64.u),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DBGKD_MANIPULATE_STATE64>((mem, ptr) => new _DBGKD_MANIPULATE_STATE64(mem, ptr), offsets);
        }
    }
}