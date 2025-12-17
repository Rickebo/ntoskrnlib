using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KERNEL_SHADOW_STACK_LIMIT")]
    public sealed class KernelShadowStackLimit : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AllFields { get => ReadHere<ulong>(nameof(AllFields)); set => WriteHere(nameof(AllFields), value); }

        [Offset(0UL)]
        public ulong ShadowStackType { get => ReadHere<ulong>(nameof(ShadowStackType)); set => WriteHere(nameof(ShadowStackType), value); }

        [Offset(0UL)]
        public ulong Unused { get => ReadHere<ulong>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        [Offset(0UL)]
        public ulong ShadowStackLimitPfn { get => ReadHere<ulong>(nameof(ShadowStackLimitPfn)); set => WriteHere(nameof(ShadowStackLimitPfn), value); }

        public KernelShadowStackLimit(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KernelShadowStackLimit>();
        }
    }
}