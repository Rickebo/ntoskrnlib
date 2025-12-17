using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_VA_ASSIGNMENT")]
    public sealed class MiSystemVaAssignment : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr BaseAddress { get => ReadHere<IntPtr>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(8UL)]
        public ulong NumberOfBytes { get => ReadHere<ulong>(nameof(NumberOfBytes)); set => WriteHere(nameof(NumberOfBytes), value); }

        public MiSystemVaAssignment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemVaAssignment>();
        }
    }
}