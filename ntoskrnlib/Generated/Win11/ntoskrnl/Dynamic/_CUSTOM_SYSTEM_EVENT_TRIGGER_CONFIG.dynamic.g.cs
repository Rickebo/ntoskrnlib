using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG")]
    public sealed class _CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG : DynamicStructure
    {
        public uint Size { get; }
        public IntPtr TriggerId { get; }

        public _CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG.TriggerId),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG>((mem, ptr) => new _CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG(mem, ptr), offsets);
        }
    }
}