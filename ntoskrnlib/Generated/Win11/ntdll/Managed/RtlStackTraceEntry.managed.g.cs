using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_STACK_TRACE_ENTRY")]
    public sealed class RtlStackTraceEntry : DynamicStructure
    {
        [Offset(0UL)]
        public RtlStdListEntry HashChain { get => ReadStructure<RtlStdListEntry>(nameof(HashChain)); set => WriteStructure(nameof(HashChain), value); }

        [Offset(8UL)]
        public ushort TraceCount { get => ReadHere<ushort>(nameof(TraceCount)); set => WriteHere(nameof(TraceCount), value); }

        [Offset(8UL)]
        public ushort BlockDepth { get => ReadHere<ushort>(nameof(BlockDepth)); set => WriteHere(nameof(BlockDepth), value); }

        [Offset(10UL)]
        public ushort IndexHigh { get => ReadHere<ushort>(nameof(IndexHigh)); set => WriteHere(nameof(IndexHigh), value); }

        [Offset(12UL)]
        public ushort Index { get => ReadHere<ushort>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(14UL)]
        public ushort Depth { get => ReadHere<ushort>(nameof(Depth)); set => WriteHere(nameof(Depth), value); }

        [Offset(16UL)]
        [Length(32)]
        public DynamicArray BackTrace { get => ReadStructure<DynamicArray>(nameof(BackTrace)); set => WriteStructure(nameof(BackTrace), value); }

        [Offset(16UL)]
        public SlistEntry FreeChain { get => ReadStructure<SlistEntry>(nameof(FreeChain)); set => WriteStructure(nameof(FreeChain), value); }

        public RtlStackTraceEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlStackTraceEntry>();
        }
    }
}