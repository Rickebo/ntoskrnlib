using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_TRIAGE_DUMP_DATA")]
    public sealed class _MI_TRIAGE_DUMP_DATA : DynamicStructure
    {
        public ulong BadPageCount { get; }
        public uint BadPagesDetected { get; }
        public int ZeroedPageSingleBitErrorsDetected { get; }
        public int ScrubPasses { get; }
        public int ScrubBadPagesFound { get; }
        public uint PageHashErrors { get; }
        public ulong FeatureBits { get; }
        public uint TimeZoneId { get; }
        public _MI_FLAGS Flags { get; }
        public IntPtr VsmConnection { get; }

        public _MI_TRIAGE_DUMP_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_TRIAGE_DUMP_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.BadPageCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.BadPagesDetected),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.ZeroedPageSingleBitErrorsDetected),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.ScrubPasses),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.ScrubBadPagesFound),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.PageHashErrors),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.FeatureBits),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.TimeZoneId),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.Flags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_TRIAGE_DUMP_DATA.VsmConnection),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_MI_TRIAGE_DUMP_DATA>((mem, ptr) => new _MI_TRIAGE_DUMP_DATA(mem, ptr), offsets);
        }
    }
}