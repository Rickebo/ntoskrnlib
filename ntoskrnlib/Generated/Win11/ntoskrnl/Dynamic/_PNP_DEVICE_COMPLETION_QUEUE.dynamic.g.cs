using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_COMPLETION_QUEUE")]
    public sealed class _PNP_DEVICE_COMPLETION_QUEUE : DynamicStructure
    {
        public _LIST_ENTRY DispatchedList { get; }
        public uint DispatchedCount { get; }
        public _LIST_ENTRY CompletedList { get; }
        public _KSEMAPHORE CompletedSemaphore { get; }
        public ulong SpinLock { get; }

        public _PNP_DEVICE_COMPLETION_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_DEVICE_COMPLETION_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_DEVICE_COMPLETION_QUEUE.DispatchedList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_QUEUE.DispatchedCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_QUEUE.CompletedList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_QUEUE.CompletedSemaphore),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_QUEUE.SpinLock),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_PNP_DEVICE_COMPLETION_QUEUE>((mem, ptr) => new _PNP_DEVICE_COMPLETION_QUEUE(mem, ptr), offsets);
        }
    }
}