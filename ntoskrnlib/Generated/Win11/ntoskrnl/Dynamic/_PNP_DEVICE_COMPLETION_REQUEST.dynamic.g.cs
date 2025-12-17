using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_COMPLETION_REQUEST")]
    public sealed class _PNP_DEVICE_COMPLETION_REQUEST : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr DeviceNode { get; }
        public IntPtr Context { get; }
        public uint CompletionState { get; }
        public uint IrpPended { get; }
        public int Status { get; }
        public IntPtr Information { get; }
        public int ReferenceCount { get; }
        public IntPtr Watchdog { get; }

        public _PNP_DEVICE_COMPLETION_REQUEST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_DEVICE_COMPLETION_REQUEST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.DeviceNode),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.Context),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.CompletionState),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.IrpPended),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.Status),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.Information),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.ReferenceCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_COMPLETION_REQUEST.Watchdog),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_PNP_DEVICE_COMPLETION_REQUEST>((mem, ptr) => new _PNP_DEVICE_COMPLETION_REQUEST(mem, ptr), offsets);
        }
    }
}