using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_LIST_HEADER")]
    public sealed class _ALPC_COMPLETION_LIST_HEADER : DynamicStructure
    {
        public ulong StartMagic { get; }
        public uint TotalSize { get; }
        public uint ListOffset { get; }
        public uint ListSize { get; }
        public uint BitmapOffset { get; }
        public uint BitmapSize { get; }
        public uint DataOffset { get; }
        public uint DataSize { get; }
        public uint AttributeFlags { get; }
        public uint AttributeSize { get; }
        public _ALPC_COMPLETION_LIST_STATE State { get; }
        public uint LastMessageId { get; }
        public uint LastCallbackId { get; }
        public uint PostCount { get; }
        public uint ReturnCount { get; }
        public uint LogSequenceNumber { get; }
        public _RTL_SRWLOCK UserLock { get; }
        public ulong EndMagic { get; }

        public _ALPC_COMPLETION_LIST_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_COMPLETION_LIST_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.StartMagic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.TotalSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.ListOffset),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.ListSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.BitmapOffset),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.BitmapSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.DataOffset),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.DataSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.AttributeFlags),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.AttributeSize),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.State),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.LastMessageId),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.LastCallbackId),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.PostCount),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.ReturnCount),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.LogSequenceNumber),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.UserLock),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_ALPC_COMPLETION_LIST_HEADER.EndMagic),
                    new ulong[]
                    {
                        328UL
                    }
                }
            };
            Register<_ALPC_COMPLETION_LIST_HEADER>((mem, ptr) => new _ALPC_COMPLETION_LIST_HEADER(mem, ptr), offsets);
        }
    }
}