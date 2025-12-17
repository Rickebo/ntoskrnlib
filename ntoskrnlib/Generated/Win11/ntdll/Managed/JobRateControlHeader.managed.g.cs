using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_JOB_RATE_CONTROL_HEADER")]
    public sealed class JobRateControlHeader : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr RateControlQuotaReference { get => ReadHere<IntPtr>(nameof(RateControlQuotaReference)); set => WriteHere(nameof(RateControlQuotaReference), value); }

        [Offset(8UL)]
        public RtlBitmap OverQuotaHistory { get => ReadStructure<RtlBitmap>(nameof(OverQuotaHistory)); set => WriteStructure(nameof(OverQuotaHistory), value); }

        [Offset(24UL)]
        public IntPtr BitMapBuffer { get => ReadHere<IntPtr>(nameof(BitMapBuffer)); set => WriteHere(nameof(BitMapBuffer), value); }

        [Offset(32UL)]
        public ulong BitMapBufferSize { get => ReadHere<ulong>(nameof(BitMapBufferSize)); set => WriteHere(nameof(BitMapBufferSize), value); }

        public JobRateControlHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<JobRateControlHeader>();
        }
    }
}