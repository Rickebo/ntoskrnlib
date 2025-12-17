using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_REQUEST_MAILBOX")]
    public sealed class _REQUEST_MAILBOX : DynamicStructure
    {
        public IntPtr Next { get; }
        public ulong RequestSummary { get; }
        public _KREQUEST_PACKET RequestPacket { get; }
        public IntPtr SubNodeTargetCountAddr { get; }
        public int SubNodeTargetCount { get; }

        public _REQUEST_MAILBOX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _REQUEST_MAILBOX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_REQUEST_MAILBOX.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_REQUEST_MAILBOX.RequestSummary),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_REQUEST_MAILBOX.RequestPacket),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_REQUEST_MAILBOX.SubNodeTargetCountAddr),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_REQUEST_MAILBOX.SubNodeTargetCount),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_REQUEST_MAILBOX>((mem, ptr) => new _REQUEST_MAILBOX(mem, ptr), offsets);
        }
    }
}