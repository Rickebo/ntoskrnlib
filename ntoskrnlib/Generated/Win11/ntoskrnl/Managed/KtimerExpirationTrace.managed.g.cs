using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTIMER_EXPIRATION_TRACE")]
    public sealed class KtimerExpirationTrace : DynamicStructure
    {
        [Offset(0UL)]
        public ulong InterruptTime { get => ReadHere<ulong>(nameof(InterruptTime)); set => WriteHere(nameof(InterruptTime), value); }

        [Offset(8UL)]
        public LargeInteger PerformanceCounter { get => ReadStructure<LargeInteger>(nameof(PerformanceCounter)); set => WriteStructure(nameof(PerformanceCounter), value); }

        public KtimerExpirationTrace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtimerExpirationTrace>();
        }
    }
}