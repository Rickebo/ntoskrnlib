using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_DLL_OVERFLOW_AREA")]
    public sealed class MiDllOverflowArea : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr RangeStart { get => ReadHere<IntPtr>(nameof(RangeStart)); set => WriteHere(nameof(RangeStart), value); }

        [Offset(8UL)]
        public IntPtr NextVa { get => ReadHere<IntPtr>(nameof(NextVa)); set => WriteHere(nameof(NextVa), value); }

        [Offset(16UL)]
        public IntPtr RangeStartAbove2gb { get => ReadHere<IntPtr>(nameof(RangeStartAbove2gb)); set => WriteHere(nameof(RangeStartAbove2gb), value); }

        [Offset(24UL)]
        public IntPtr NextVaAbove2gb { get => ReadHere<IntPtr>(nameof(NextVaAbove2gb)); set => WriteHere(nameof(NextVaAbove2gb), value); }

        public MiDllOverflowArea(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiDllOverflowArea>();
        }
    }
}