using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_PNP_DEVICE_COMPLETION_REQUEST")]
    public sealed class _TRIAGE_PNP_DEVICE_COMPLETION_REQUEST : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr DeviceNode { get; }

        public _TRIAGE_PNP_DEVICE_COMPLETION_REQUEST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_PNP_DEVICE_COMPLETION_REQUEST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_PNP_DEVICE_COMPLETION_REQUEST.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRIAGE_PNP_DEVICE_COMPLETION_REQUEST.DeviceNode),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_TRIAGE_PNP_DEVICE_COMPLETION_REQUEST>((mem, ptr) => new _TRIAGE_PNP_DEVICE_COMPLETION_REQUEST(mem, ptr), offsets);
        }
    }
}