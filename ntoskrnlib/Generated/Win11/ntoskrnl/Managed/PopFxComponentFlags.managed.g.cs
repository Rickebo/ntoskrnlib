using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_COMPONENT_FLAGS")]
    public sealed class PopFxComponentFlags : DynamicStructure
    {
        [Offset(0UL)]
        public int Value { get => ReadHere<int>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(4UL)]
        public int Value2 { get => ReadHere<int>(nameof(Value2)); set => WriteHere(nameof(Value2), value); }

        [Offset(0UL)]
        public uint RefCount { get => ReadHere<uint>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(0UL)]
        public uint Idling { get => ReadHere<uint>(nameof(Idling)); set => WriteHere(nameof(Idling), value); }

        [Offset(0UL)]
        public uint Active { get => ReadHere<uint>(nameof(Active)); set => WriteHere(nameof(Active), value); }

        [Offset(4UL)]
        public uint CriticalIdleOverride { get => ReadHere<uint>(nameof(CriticalIdleOverride)); set => WriteHere(nameof(CriticalIdleOverride), value); }

        [Offset(4UL)]
        public uint ResidentOverride { get => ReadHere<uint>(nameof(ResidentOverride)); set => WriteHere(nameof(ResidentOverride), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public PopFxComponentFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxComponentFlags>();
        }
    }
}