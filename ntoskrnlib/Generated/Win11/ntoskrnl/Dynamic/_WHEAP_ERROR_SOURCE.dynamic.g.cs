using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEAP_ERROR_SOURCE")]
    public sealed class _WHEAP_ERROR_SOURCE : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public uint FailedAllocations { get; }
        public uint PlatformErrorSourceId { get; }
        public int ErrorCount { get; }
        public uint RecordCount { get; }
        public uint RecordLength { get; }
        public uint PoolTag { get; }
        public uint Type { get; }
        public IntPtr Records { get; }
        public IntPtr Context { get; }
        public uint SectionCount { get; }
        public uint SectionLength { get; }
        public _LARGE_INTEGER TickCountAtLastError { get; }
        public uint AccumulatedErrors { get; }
        public uint TotalErrors { get; }
        public byte Deferred { get; }
        public int Busy { get; }
        public _WHEA_ERROR_SOURCE_DESCRIPTOR Descriptor { get; }

        public _WHEAP_ERROR_SOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEAP_ERROR_SOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEAP_ERROR_SOURCE.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.FailedAllocations),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.PlatformErrorSourceId),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.ErrorCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.RecordCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.RecordLength),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.PoolTag),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.Type),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.Records),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.Context),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.SectionCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.SectionLength),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.TickCountAtLastError),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.AccumulatedErrors),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.TotalErrors),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.Deferred),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.Busy),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_SOURCE.Descriptor),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_WHEAP_ERROR_SOURCE>((mem, ptr) => new _WHEAP_ERROR_SOURCE(mem, ptr), offsets);
        }
    }
}