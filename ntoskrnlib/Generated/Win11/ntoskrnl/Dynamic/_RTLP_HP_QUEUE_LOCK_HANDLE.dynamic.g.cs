using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTLP_HP_QUEUE_LOCK_HANDLE")]
    public sealed class _RTLP_HP_QUEUE_LOCK_HANDLE : DynamicStructure
    {
        public ulong Reserved1 { get; }
        public ulong LockPtr { get; }
        public ulong HandleData { get; }

        public _RTLP_HP_QUEUE_LOCK_HANDLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_HP_QUEUE_LOCK_HANDLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_HP_QUEUE_LOCK_HANDLE.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_HP_QUEUE_LOCK_HANDLE.LockPtr),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTLP_HP_QUEUE_LOCK_HANDLE.HandleData),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTLP_HP_QUEUE_LOCK_HANDLE>((mem, ptr) => new _RTLP_HP_QUEUE_LOCK_HANDLE(mem, ptr), offsets);
        }
    }
}