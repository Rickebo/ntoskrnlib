using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_CRITICAL_SECTION_DEBUG")]
    public sealed class _RTL_CRITICAL_SECTION_DEBUG : DynamicStructure
    {
        public ushort Type { get; }
        public ushort CreatorBackTraceIndex { get; }
        public IntPtr CriticalSection { get; }
        public _LIST_ENTRY ProcessLocksList { get; }
        public uint EntryCount { get; }
        public uint ContentionCount { get; }
        public uint Flags { get; }
        public ushort CreatorBackTraceIndexHigh { get; }
        public ushort Identifier { get; }

        public _RTL_CRITICAL_SECTION_DEBUG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_CRITICAL_SECTION_DEBUG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.CreatorBackTraceIndex),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.CriticalSection),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.ProcessLocksList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.EntryCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.ContentionCount),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.Flags),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.CreatorBackTraceIndexHigh),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_RTL_CRITICAL_SECTION_DEBUG.Identifier),
                    new ulong[]
                    {
                        46UL
                    }
                }
            };
            Register<_RTL_CRITICAL_SECTION_DEBUG>((mem, ptr) => new _RTL_CRITICAL_SECTION_DEBUG(mem, ptr), offsets);
        }
    }
}