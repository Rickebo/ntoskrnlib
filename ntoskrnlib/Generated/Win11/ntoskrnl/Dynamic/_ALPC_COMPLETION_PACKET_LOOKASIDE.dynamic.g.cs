using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_PACKET_LOOKASIDE")]
    public sealed class _ALPC_COMPLETION_PACKET_LOOKASIDE : DynamicStructure
    {
        public ulong Lock { get; }
        public uint Size { get; }
        public uint ActiveCount { get; }
        public uint PendingNullCount { get; }
        public uint PendingCheckCompletionListCount { get; }
        public uint PendingDelete { get; }
        public _SINGLE_LIST_ENTRY FreeListHead { get; }
        public IntPtr CompletionPort { get; }
        public IntPtr CompletionKey { get; }
        public byte[] Entry { get; }

        public _ALPC_COMPLETION_PACKET_LOOKASIDE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_COMPLETION_PACKET_LOOKASIDE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.ActiveCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.PendingNullCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.PendingCheckCompletionListCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.PendingDelete),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.FreeListHead),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.CompletionPort),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.CompletionKey),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_PACKET_LOOKASIDE.Entry),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_ALPC_COMPLETION_PACKET_LOOKASIDE>((mem, ptr) => new _ALPC_COMPLETION_PACKET_LOOKASIDE(mem, ptr), offsets);
        }
    }
}