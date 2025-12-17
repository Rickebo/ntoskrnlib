using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_TRACE_BLOCK")]
    public sealed class RtlTraceBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint Magic { get => ReadHere<uint>(nameof(Magic)); set => WriteHere(nameof(Magic), value); }

        [Offset(4UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(16UL)]
        public ulong UserCount { get => ReadHere<ulong>(nameof(UserCount)); set => WriteHere(nameof(UserCount), value); }

        [Offset(24UL)]
        public ulong UserSize { get => ReadHere<ulong>(nameof(UserSize)); set => WriteHere(nameof(UserSize), value); }

        [Offset(32UL)]
        public IntPtr UserContext { get => ReadHere<IntPtr>(nameof(UserContext)); set => WriteHere(nameof(UserContext), value); }

        [Offset(40UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(48UL)]
        public IntPtr Trace { get => ReadHere<IntPtr>(nameof(Trace)); set => WriteHere(nameof(Trace), value); }

        public RtlTraceBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlTraceBlock>();
        }
    }
}