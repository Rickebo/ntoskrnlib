using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_HEADER")]
    public sealed class _ETW_FILTER_HEADER : DynamicStructure
    {
        public int FilterFlags { get; }
        public IntPtr PidFilter { get; }
        public IntPtr ExeFilter { get; }
        public IntPtr PkgIdFilter { get; }
        public IntPtr PkgAppIdFilter { get; }
        public IntPtr ContainerFilter { get; }
        public IntPtr StackWalkIdFilter { get; }
        public IntPtr StackWalkNameFilter { get; }
        public IntPtr StackWalkLevelKwFilter { get; }
        public IntPtr EventIdFilter { get; }
        public IntPtr PayloadFilter { get; }
        public IntPtr ProviderSideFilter { get; }
        public IntPtr EventNameFilter { get; }

        public _ETW_FILTER_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_FILTER_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_FILTER_HEADER.FilterFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.PidFilter),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.ExeFilter),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.PkgIdFilter),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.PkgAppIdFilter),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.ContainerFilter),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.StackWalkIdFilter),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.StackWalkNameFilter),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.StackWalkLevelKwFilter),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.EventIdFilter),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.PayloadFilter),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.ProviderSideFilter),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_ETW_FILTER_HEADER.EventNameFilter),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_ETW_FILTER_HEADER>((mem, ptr) => new _ETW_FILTER_HEADER(mem, ptr), offsets);
        }
    }
}