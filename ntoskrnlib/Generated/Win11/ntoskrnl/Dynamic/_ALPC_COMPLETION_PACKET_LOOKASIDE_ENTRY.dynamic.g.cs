using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY")]
    public sealed class _ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY : DynamicStructure
    {
        public _SINGLE_LIST_ENTRY ListEntry { get; }
        public IntPtr Packet { get; }
        public IntPtr Lookaside { get; }

        public _ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY.Packet),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY.Lookaside),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY>((mem, ptr) => new _ALPC_COMPLETION_PACKET_LOOKASIDE_ENTRY(mem, ptr), offsets);
        }
    }
}