using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_RESTRICTED_MODWRITES")]
    public sealed class MiRestrictedModwrites : DynamicStructure
    {
        [Offset(0UL)]
        public byte MaximumClusterPages { get => ReadHere<byte>(nameof(MaximumClusterPages)); set => WriteHere(nameof(MaximumClusterPages), value); }

        [Offset(1UL)]
        public byte ReducedClusterWrites { get => ReadHere<byte>(nameof(ReducedClusterWrites)); set => WriteHere(nameof(ReducedClusterWrites), value); }

        [Offset(2UL)]
        public byte ImposeDelay { get => ReadHere<byte>(nameof(ImposeDelay)); set => WriteHere(nameof(ImposeDelay), value); }

        public MiRestrictedModwrites(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiRestrictedModwrites>();
        }
    }
}