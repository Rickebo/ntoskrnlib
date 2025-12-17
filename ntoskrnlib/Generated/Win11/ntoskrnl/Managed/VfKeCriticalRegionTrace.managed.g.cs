using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_KE_CRITICAL_REGION_TRACE")]
    public sealed class VfKeCriticalRegionTrace : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(8UL)]
        [Length(7)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        public VfKeCriticalRegionTrace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfKeCriticalRegionTrace>();
        }
    }
}