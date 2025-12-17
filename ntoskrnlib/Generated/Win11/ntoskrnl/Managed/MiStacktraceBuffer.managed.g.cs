using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_STACKTRACE_BUFFER")]
    public sealed class MiStacktraceBuffer : DynamicStructure
    {
        [Offset(0UL)]
        [Length(20)]
        public DynamicArray CallingFunction { get => ReadStructure<DynamicArray>(nameof(CallingFunction)); set => WriteStructure(nameof(CallingFunction), value); }

        public MiStacktraceBuffer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiStacktraceBuffer>();
        }
    }
}