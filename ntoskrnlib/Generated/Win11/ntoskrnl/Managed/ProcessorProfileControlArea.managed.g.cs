using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_PROFILE_CONTROL_AREA")]
    public sealed class ProcessorProfileControlArea : DynamicStructure
    {
        [Offset(0UL)]
        public PebsDsSaveArea PebsDsSaveArea { get => ReadStructure<PebsDsSaveArea>(nameof(PebsDsSaveArea)); set => WriteStructure(nameof(PebsDsSaveArea), value); }

        [Offset(0UL)]
        public IntPtr RawBuffer { get => ReadHere<IntPtr>(nameof(RawBuffer)); set => WriteHere(nameof(RawBuffer), value); }

        public ProcessorProfileControlArea(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorProfileControlArea>();
        }
    }
}