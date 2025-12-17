using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_EVENT_LOG_ENTRY_FLAGS")]
    public sealed class _WHEA_EVENT_LOG_ENTRY_FLAGS : DynamicStructure
    {
        public uint Reserved1 { get; }
        public uint LogInternalEtw { get; }
        public uint LogBlackbox { get; }
        public uint LogSel { get; }
        public uint RawSel { get; }
        public uint NoFormat { get; }
        public uint Driver { get; }
        public uint Reserved2 { get; }
        public uint AsULONG { get; }

        public _WHEA_EVENT_LOG_ENTRY_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_EVENT_LOG_ENTRY_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.LogInternalEtw),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.LogBlackbox),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.LogSel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.RawSel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.NoFormat),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.Driver),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.Reserved2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_FLAGS.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_EVENT_LOG_ENTRY_FLAGS>((mem, ptr) => new _WHEA_EVENT_LOG_ENTRY_FLAGS(mem, ptr), offsets);
        }
    }
}