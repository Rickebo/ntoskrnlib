using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KRESOURCEMANAGER_COMPLETION_BINDING")]
    public sealed class _KRESOURCEMANAGER_COMPLETION_BINDING : DynamicStructure
    {
        public _LIST_ENTRY NotificationListHead { get; }
        public IntPtr Port { get; }
        public ulong Key { get; }
        public IntPtr BindingProcess { get; }

        public _KRESOURCEMANAGER_COMPLETION_BINDING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KRESOURCEMANAGER_COMPLETION_BINDING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KRESOURCEMANAGER_COMPLETION_BINDING.NotificationListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER_COMPLETION_BINDING.Port),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER_COMPLETION_BINDING.Key),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KRESOURCEMANAGER_COMPLETION_BINDING.BindingProcess),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_KRESOURCEMANAGER_COMPLETION_BINDING>((mem, ptr) => new _KRESOURCEMANAGER_COMPLETION_BINDING(mem, ptr), offsets);
        }
    }
}