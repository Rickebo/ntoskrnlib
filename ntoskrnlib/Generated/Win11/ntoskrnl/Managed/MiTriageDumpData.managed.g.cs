using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_TRIAGE_DUMP_DATA")]
    public sealed class MiTriageDumpData : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BadPageCount { get => ReadHere<ulong>(nameof(BadPageCount)); set => WriteHere(nameof(BadPageCount), value); }

        [Offset(8UL)]
        public uint BadPagesDetected { get => ReadHere<uint>(nameof(BadPagesDetected)); set => WriteHere(nameof(BadPagesDetected), value); }

        [Offset(12UL)]
        public int ZeroedPageSingleBitErrorsDetected { get => ReadHere<int>(nameof(ZeroedPageSingleBitErrorsDetected)); set => WriteHere(nameof(ZeroedPageSingleBitErrorsDetected), value); }

        [Offset(16UL)]
        public int ScrubPasses { get => ReadHere<int>(nameof(ScrubPasses)); set => WriteHere(nameof(ScrubPasses), value); }

        [Offset(20UL)]
        public int ScrubBadPagesFound { get => ReadHere<int>(nameof(ScrubBadPagesFound)); set => WriteHere(nameof(ScrubBadPagesFound), value); }

        [Offset(24UL)]
        public uint PageHashErrors { get => ReadHere<uint>(nameof(PageHashErrors)); set => WriteHere(nameof(PageHashErrors), value); }

        [Offset(32UL)]
        public ulong FeatureBits { get => ReadHere<ulong>(nameof(FeatureBits)); set => WriteHere(nameof(FeatureBits), value); }

        [Offset(40UL)]
        public uint TimeZoneId { get => ReadHere<uint>(nameof(TimeZoneId)); set => WriteHere(nameof(TimeZoneId), value); }

        [Offset(48UL)]
        public MiFlags Flags { get => ReadStructure<MiFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(56UL)]
        public IntPtr VsmConnection { get => ReadHere<IntPtr>(nameof(VsmConnection)); set => WriteHere(nameof(VsmConnection), value); }

        public MiTriageDumpData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiTriageDumpData>();
        }
    }
}