using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_HW_TRACE_EXT_INTERFACE")]
    public sealed class EtwHwTraceExtInterface : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr StartProcessorTraceOnEachCore { get => ReadHere<IntPtr>(nameof(StartProcessorTraceOnEachCore)); set => WriteHere(nameof(StartProcessorTraceOnEachCore), value); }

        [Offset(8UL)]
        public IntPtr StopProcessorTraceOnEachCore { get => ReadHere<IntPtr>(nameof(StopProcessorTraceOnEachCore)); set => WriteHere(nameof(StopProcessorTraceOnEachCore), value); }

        [Offset(16UL)]
        public IntPtr LogProcessorTraceOnCurrentCore { get => ReadHere<IntPtr>(nameof(LogProcessorTraceOnCurrentCore)); set => WriteHere(nameof(LogProcessorTraceOnCurrentCore), value); }

        public EtwHwTraceExtInterface(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwHwTraceExtInterface>();
        }
    }
}