using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_MANIPULATE_STATE32")]
    public sealed class _DBGKD_MANIPULATE_STATE32 : DynamicStructure
    {
        public uint ApiNumber { get; }
        public ushort ProcessorLevel { get; }
        public ushort Processor { get; }
        public int ReturnStatus { get; }
        public _unnamed_tag_ u { get; }

        public _DBGKD_MANIPULATE_STATE32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_MANIPULATE_STATE32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_MANIPULATE_STATE32.ApiNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_MANIPULATE_STATE32.ProcessorLevel),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_MANIPULATE_STATE32.Processor),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_DBGKD_MANIPULATE_STATE32.ReturnStatus),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGKD_MANIPULATE_STATE32.u),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_DBGKD_MANIPULATE_STATE32>((mem, ptr) => new _DBGKD_MANIPULATE_STATE32(mem, ptr), offsets);
        }
    }
}