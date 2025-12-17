using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_RESOURCE_CONFLICT_TRACE_CONTEXT")]
    public sealed class PnpResourceConflictTraceContext : DynamicStructure
    {
        [Offset(0UL)]
        public byte ResourceType { get => ReadHere<byte>(nameof(ResourceType)); set => WriteHere(nameof(ResourceType), value); }

        [Offset(4UL)]
        public uint AlternativeCount { get => ReadHere<uint>(nameof(AlternativeCount)); set => WriteHere(nameof(AlternativeCount), value); }

        [Offset(8UL)]
        public IntPtr ResourceRequests { get => ReadHere<IntPtr>(nameof(ResourceRequests)); set => WriteHere(nameof(ResourceRequests), value); }

        [Offset(16UL)]
        public IntPtr ArbiterInstance { get => ReadHere<IntPtr>(nameof(ArbiterInstance)); set => WriteHere(nameof(ArbiterInstance), value); }

        public PnpResourceConflictTraceContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpResourceConflictTraceContext>();
        }
    }
}