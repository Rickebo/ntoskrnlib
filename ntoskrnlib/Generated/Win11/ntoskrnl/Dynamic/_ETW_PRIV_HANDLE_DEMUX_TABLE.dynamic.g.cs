using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_PRIV_HANDLE_DEMUX_TABLE")]
    public sealed class _ETW_PRIV_HANDLE_DEMUX_TABLE : DynamicStructure
    {
        public _RTL_RB_TREE Tree { get; }
        public _EX_PUSH_LOCK Lock { get; }
        public ushort SequenceNumber { get; }

        public _ETW_PRIV_HANDLE_DEMUX_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_PRIV_HANDLE_DEMUX_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_PRIV_HANDLE_DEMUX_TABLE.Tree),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_PRIV_HANDLE_DEMUX_TABLE.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_PRIV_HANDLE_DEMUX_TABLE.SequenceNumber),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_ETW_PRIV_HANDLE_DEMUX_TABLE>((mem, ptr) => new _ETW_PRIV_HANDLE_DEMUX_TABLE(mem, ptr), offsets);
        }
    }
}