using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_FAULT_TRACE")]
    public sealed class ViFaultTrace : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(8UL)]
        [Length(8)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        public ViFaultTrace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViFaultTrace>();
        }
    }
}