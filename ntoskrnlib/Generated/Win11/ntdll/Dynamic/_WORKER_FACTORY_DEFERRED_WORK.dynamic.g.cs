using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WORKER_FACTORY_DEFERRED_WORK")]
    public sealed class _WORKER_FACTORY_DEFERRED_WORK : DynamicStructure
    {
        public IntPtr AlpcSendMessage { get; }
        public IntPtr AlpcSendMessagePort { get; }
        public uint AlpcSendMessageFlags { get; }
        public uint Flags { get; }

        public _WORKER_FACTORY_DEFERRED_WORK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WORKER_FACTORY_DEFERRED_WORK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WORKER_FACTORY_DEFERRED_WORK.AlpcSendMessage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WORKER_FACTORY_DEFERRED_WORK.AlpcSendMessagePort),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WORKER_FACTORY_DEFERRED_WORK.AlpcSendMessageFlags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WORKER_FACTORY_DEFERRED_WORK.Flags),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_WORKER_FACTORY_DEFERRED_WORK>((mem, ptr) => new _WORKER_FACTORY_DEFERRED_WORK(mem, ptr), offsets);
        }
    }
}