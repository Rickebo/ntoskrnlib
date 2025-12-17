using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_QUERY_CONFLICT_PARAMETERS")]
    public sealed class ArbiterQueryConflictParameters : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PhysicalDeviceObject { get => ReadHere<IntPtr>(nameof(PhysicalDeviceObject)); set => WriteHere(nameof(PhysicalDeviceObject), value); }

        [Offset(8UL)]
        public IntPtr ConflictingResource { get => ReadHere<IntPtr>(nameof(ConflictingResource)); set => WriteHere(nameof(ConflictingResource), value); }

        [Offset(16UL)]
        public IntPtr ConflictCount { get => ReadHere<IntPtr>(nameof(ConflictCount)); set => WriteHere(nameof(ConflictCount), value); }

        [Offset(24UL)]
        public IntPtr Conflicts { get => ReadHere<IntPtr>(nameof(Conflicts)); set => WriteHere(nameof(Conflicts), value); }

        public ArbiterQueryConflictParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterQueryConflictParameters>();
        }
    }
}