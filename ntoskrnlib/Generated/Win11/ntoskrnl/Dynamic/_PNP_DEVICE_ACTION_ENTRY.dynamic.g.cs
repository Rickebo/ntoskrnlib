using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_ACTION_ENTRY")]
    public sealed class _PNP_DEVICE_ACTION_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr DeviceObject { get; }
        public uint RequestType { get; }
        public byte ReorderingBarrier { get; }
        public _PNP_DEVICE_ACTION_REQUEST_ARGUMENT RequestArgument { get; }
        public IntPtr CompletionEvent { get; }
        public IntPtr CompletionStatus { get; }
        public _GUID ActivityId { get; }
        public int RefCount { get; }
        public byte Dequeued { get; }
        public _EX_PUSH_LOCK CancelLock { get; }
        public byte CancelRequested { get; }

        public _PNP_DEVICE_ACTION_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_DEVICE_ACTION_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.DeviceObject),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.RequestType),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.ReorderingBarrier),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.RequestArgument),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.CompletionEvent),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.CompletionStatus),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.ActivityId),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.RefCount),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.Dequeued),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.CancelLock),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_ENTRY.CancelRequested),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_PNP_DEVICE_ACTION_ENTRY>((mem, ptr) => new _PNP_DEVICE_ACTION_ENTRY(mem, ptr), offsets);
        }
    }
}