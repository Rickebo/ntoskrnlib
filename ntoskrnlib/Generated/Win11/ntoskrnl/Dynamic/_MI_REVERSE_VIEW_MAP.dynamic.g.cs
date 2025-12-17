using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_REVERSE_VIEW_MAP")]
    public sealed class _MI_REVERSE_VIEW_MAP : DynamicStructure
    {
        public _LIST_ENTRY ViewLinks { get; }
        public IntPtr SystemCacheVa { get; }
        public IntPtr VadsProcess { get; }
        public ulong Type { get; }
        public IntPtr Subsection { get; }
        public ulong SubsectionType { get; }
        public _MI_REVERSE_MAP_VIEW_ATTRIBUTES Attributes { get; }

        public _MI_REVERSE_VIEW_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_REVERSE_VIEW_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_REVERSE_VIEW_MAP.ViewLinks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_REVERSE_VIEW_MAP.SystemCacheVa),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_REVERSE_VIEW_MAP.VadsProcess),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_REVERSE_VIEW_MAP.Type),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_REVERSE_VIEW_MAP.Subsection),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_REVERSE_VIEW_MAP.SubsectionType),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_REVERSE_VIEW_MAP.Attributes),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_MI_REVERSE_VIEW_MAP>((mem, ptr) => new _MI_REVERSE_VIEW_MAP(mem, ptr), offsets);
        }
    }
}