using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRACE_ENABLE_INFO")]
    public sealed class TraceEnableInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint IsEnabled { get => ReadHere<uint>(nameof(IsEnabled)); set => WriteHere(nameof(IsEnabled), value); }

        [Offset(4UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(5UL)]
        public byte Reserved1 { get => ReadHere<byte>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(6UL)]
        public ushort LoggerId { get => ReadHere<ushort>(nameof(LoggerId)); set => WriteHere(nameof(LoggerId), value); }

        [Offset(8UL)]
        public uint EnableProperty { get => ReadHere<uint>(nameof(EnableProperty)); set => WriteHere(nameof(EnableProperty), value); }

        [Offset(12UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(16UL)]
        public ulong MatchAnyKeyword { get => ReadHere<ulong>(nameof(MatchAnyKeyword)); set => WriteHere(nameof(MatchAnyKeyword), value); }

        [Offset(24UL)]
        public ulong MatchAllKeyword { get => ReadHere<ulong>(nameof(MatchAllKeyword)); set => WriteHere(nameof(MatchAllKeyword), value); }

        public TraceEnableInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TraceEnableInfo>();
        }
    }
}