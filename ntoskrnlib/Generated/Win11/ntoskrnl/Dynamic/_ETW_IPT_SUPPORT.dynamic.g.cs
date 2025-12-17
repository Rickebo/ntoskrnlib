using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_IPT_SUPPORT")]
    public sealed class _ETW_IPT_SUPPORT : DynamicStructure
    {
        public IntPtr IptHandle { get; }
        public ulong IptOption { get; }
        public IntPtr EtwHwTraceExtInterface { get; }
        public uint HookIdCount { get; }
        public ushort[] HookId { get; }

        public _ETW_IPT_SUPPORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_IPT_SUPPORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_IPT_SUPPORT.IptHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_IPT_SUPPORT.IptOption),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_IPT_SUPPORT.EtwHwTraceExtInterface),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_IPT_SUPPORT.HookIdCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETW_IPT_SUPPORT.HookId),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_ETW_IPT_SUPPORT>((mem, ptr) => new _ETW_IPT_SUPPORT(mem, ptr), offsets);
        }
    }
}