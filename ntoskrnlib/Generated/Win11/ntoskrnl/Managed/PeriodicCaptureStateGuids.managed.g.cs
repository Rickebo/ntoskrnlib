using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PERIODIC_CAPTURE_STATE_GUIDS")]
    public sealed class PeriodicCaptureStateGuids : DynamicStructure
    {
        [Offset(0UL)]
        public ushort ProviderCount { get => ReadHere<ushort>(nameof(ProviderCount)); set => WriteHere(nameof(ProviderCount), value); }

        [Offset(8UL)]
        public IntPtr Providers { get => ReadHere<IntPtr>(nameof(Providers)); set => WriteHere(nameof(Providers), value); }

        public PeriodicCaptureStateGuids(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PeriodicCaptureStateGuids>();
        }
    }
}