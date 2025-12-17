using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KHETERO_HWFEEDBACK_CLASS")]
    public sealed class KheteroHwfeedbackClass : DynamicStructure
    {
        [Offset(0UL)]
        public byte PerformanceClass { get => ReadHere<byte>(nameof(PerformanceClass)); set => WriteHere(nameof(PerformanceClass), value); }

        [Offset(1UL)]
        public byte EfficiencyClass { get => ReadHere<byte>(nameof(EfficiencyClass)); set => WriteHere(nameof(EfficiencyClass), value); }

        [Offset(2UL)]
        public byte PerformanceClassRawValue { get => ReadHere<byte>(nameof(PerformanceClassRawValue)); set => WriteHere(nameof(PerformanceClassRawValue), value); }

        [Offset(3UL)]
        public byte EfficiencyClassRawValue { get => ReadHere<byte>(nameof(EfficiencyClassRawValue)); set => WriteHere(nameof(EfficiencyClassRawValue), value); }

        public KheteroHwfeedbackClass(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KheteroHwfeedbackClass>();
        }
    }
}