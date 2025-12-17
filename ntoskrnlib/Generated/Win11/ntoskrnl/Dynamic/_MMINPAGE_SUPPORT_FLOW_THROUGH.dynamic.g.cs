using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMINPAGE_SUPPORT_FLOW_THROUGH")]
    public sealed class _MMINPAGE_SUPPORT_FLOW_THROUGH : DynamicStructure
    {
        public ulong[] Page { get; }
        public IntPtr InitialInPageSupport { get; }
        public IntPtr PagingFile { get; }
        public uint PageFileOffset { get; }
        public _RTL_BALANCED_NODE Node { get; }

        public _MMINPAGE_SUPPORT_FLOW_THROUGH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMINPAGE_SUPPORT_FLOW_THROUGH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMINPAGE_SUPPORT_FLOW_THROUGH.Page),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT_FLOW_THROUGH.InitialInPageSupport),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT_FLOW_THROUGH.PagingFile),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT_FLOW_THROUGH.PageFileOffset),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMINPAGE_SUPPORT_FLOW_THROUGH.Node),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_MMINPAGE_SUPPORT_FLOW_THROUGH>((mem, ptr) => new _MMINPAGE_SUPPORT_FLOW_THROUGH(mem, ptr), offsets);
        }
    }
}