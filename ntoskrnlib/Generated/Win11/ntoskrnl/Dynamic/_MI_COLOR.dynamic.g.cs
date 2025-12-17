using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_COLOR")]
    public sealed class _MI_COLOR : DynamicStructure
    {
        public uint EntireField { get; }
        public uint Cache { get; }
        public uint Channel { get; }
        public uint Node { get; }
        public uint HighLow { get; }
        public uint LargePageIndex { get; }
        public uint CacheAttribute { get; }
        public uint ListName { get; }

        public _MI_COLOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_COLOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_COLOR.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COLOR.Cache),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COLOR.Channel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COLOR.Node),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COLOR.HighLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COLOR.LargePageIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COLOR.CacheAttribute),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_COLOR.ListName),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_COLOR>((mem, ptr) => new _MI_COLOR(mem, ptr), offsets);
        }
    }
}