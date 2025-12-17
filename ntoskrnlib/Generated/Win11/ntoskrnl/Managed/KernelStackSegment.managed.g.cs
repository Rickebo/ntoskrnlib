using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KERNEL_STACK_SEGMENT")]
    public sealed class KernelStackSegment : DynamicStructure
    {
        [Offset(0UL)]
        public ulong StackBase { get => ReadHere<ulong>(nameof(StackBase)); set => WriteHere(nameof(StackBase), value); }

        [Offset(8UL)]
        public ulong StackLimit { get => ReadHere<ulong>(nameof(StackLimit)); set => WriteHere(nameof(StackLimit), value); }

        [Offset(16UL)]
        public ulong KernelStack { get => ReadHere<ulong>(nameof(KernelStack)); set => WriteHere(nameof(KernelStack), value); }

        [Offset(24UL)]
        public ulong InitialStack { get => ReadHere<ulong>(nameof(InitialStack)); set => WriteHere(nameof(InitialStack), value); }

        [Offset(32UL)]
        public ulong KernelShadowStackBase { get => ReadHere<ulong>(nameof(KernelShadowStackBase)); set => WriteHere(nameof(KernelShadowStackBase), value); }

        [Offset(40UL)]
        public KernelShadowStackLimit KernelShadowStackLimit { get => ReadStructure<KernelShadowStackLimit>(nameof(KernelShadowStackLimit)); set => WriteStructure(nameof(KernelShadowStackLimit), value); }

        [Offset(48UL)]
        public ulong KernelShadowStack { get => ReadHere<ulong>(nameof(KernelShadowStack)); set => WriteHere(nameof(KernelShadowStack), value); }

        [Offset(56UL)]
        public ulong KernelShadowStackInitial { get => ReadHere<ulong>(nameof(KernelShadowStackInitial)); set => WriteHere(nameof(KernelShadowStackInitial), value); }

        public KernelStackSegment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KernelStackSegment>();
        }
    }
}