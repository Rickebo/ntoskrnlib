using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSTACK_CONTROL")]
    public sealed class KstackControl : DynamicStructure
    {
        [Offset(0UL)]
        public ulong StackBase { get => ReadHere<ulong>(nameof(StackBase)); set => WriteHere(nameof(StackBase), value); }

        [Offset(8UL)]
        public ulong ActualLimit { get => ReadHere<ulong>(nameof(ActualLimit)); set => WriteHere(nameof(ActualLimit), value); }

        [Offset(8UL)]
        public ulong StackExpansion { get => ReadHere<ulong>(nameof(StackExpansion)); set => WriteHere(nameof(StackExpansion), value); }

        [Offset(16UL)]
        public KernelStackSegment Previous { get => ReadStructure<KernelStackSegment>(nameof(Previous)); set => WriteStructure(nameof(Previous), value); }

        public KstackControl(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KstackControl>();
        }
    }
}