using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ACCESS_VIOLATION_RANGE")]
    public sealed class MiAccessViolationRange : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode Node { get => ReadStructure<RtlBalancedNode>(nameof(Node)); set => WriteStructure(nameof(Node), value); }

        [Offset(24UL)]
        public IntPtr Va { get => ReadHere<IntPtr>(nameof(Va)); set => WriteHere(nameof(Va), value); }

        [Offset(32UL)]
        public IntPtr EndVaInclusive { get => ReadHere<IntPtr>(nameof(EndVaInclusive)); set => WriteHere(nameof(EndVaInclusive), value); }

        public MiAccessViolationRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAccessViolationRange>();
        }
    }
}