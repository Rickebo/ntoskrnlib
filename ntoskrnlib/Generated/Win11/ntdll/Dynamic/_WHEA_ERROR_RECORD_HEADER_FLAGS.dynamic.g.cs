using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_ERROR_RECORD_HEADER_FLAGS")]
    public sealed class _WHEA_ERROR_RECORD_HEADER_FLAGS : DynamicStructure
    {
        public uint Recovered { get; }
        public uint PreviousError { get; }
        public uint Simulated { get; }
        public uint DeviceDriver { get; }
        public uint CriticalEvent { get; }
        public uint PersistPfn { get; }
        public uint SectionsTruncated { get; }
        public uint RecoveryInProgress { get; }
        public uint Throttle { get; }
        public uint Reserved { get; }
        public uint AsULONG { get; }

        public _WHEA_ERROR_RECORD_HEADER_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_RECORD_HEADER_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.Recovered),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.PreviousError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.Simulated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.DeviceDriver),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.CriticalEvent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.PersistPfn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.SectionsTruncated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.RecoveryInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.Throttle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_FLAGS.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_ERROR_RECORD_HEADER_FLAGS>((mem, ptr) => new _WHEA_ERROR_RECORD_HEADER_FLAGS(mem, ptr), offsets);
        }
    }
}