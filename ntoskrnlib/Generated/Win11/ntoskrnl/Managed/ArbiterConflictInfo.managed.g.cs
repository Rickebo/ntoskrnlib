using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_CONFLICT_INFO")]
    public sealed class ArbiterConflictInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr OwningObject { get => ReadHere<IntPtr>(nameof(OwningObject)); set => WriteHere(nameof(OwningObject), value); }

        [Offset(8UL)]
        public ulong Start { get => ReadHere<ulong>(nameof(Start)); set => WriteHere(nameof(Start), value); }

        [Offset(16UL)]
        public ulong End { get => ReadHere<ulong>(nameof(End)); set => WriteHere(nameof(End), value); }

        public ArbiterConflictInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterConflictInfo>();
        }
    }
}