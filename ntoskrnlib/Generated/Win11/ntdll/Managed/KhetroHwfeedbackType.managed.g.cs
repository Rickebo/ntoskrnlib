using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KHETRO_HWFEEDBACK_TYPE")]
    public sealed class KhetroHwfeedbackType : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(4UL)]
        [Length(1)]
        public DynamicArray HwFeedbackClass { get => ReadStructure<DynamicArray>(nameof(HwFeedbackClass)); set => WriteStructure(nameof(HwFeedbackClass), value); }

        public KhetroHwfeedbackType(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KhetroHwfeedbackType>();
        }
    }
}