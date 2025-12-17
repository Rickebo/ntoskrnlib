using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MCGEN_TRACE_CONTEXT")]
    public sealed class McgenTraceContext : DynamicStructure
    {
        [Offset(0UL)]
        public ulong RegistrationHandle { get => ReadHere<ulong>(nameof(RegistrationHandle)); set => WriteHere(nameof(RegistrationHandle), value); }

        [Offset(8UL)]
        public ulong Logger { get => ReadHere<ulong>(nameof(Logger)); set => WriteHere(nameof(Logger), value); }

        [Offset(16UL)]
        public ulong MatchAnyKeyword { get => ReadHere<ulong>(nameof(MatchAnyKeyword)); set => WriteHere(nameof(MatchAnyKeyword), value); }

        [Offset(24UL)]
        public ulong MatchAllKeyword { get => ReadHere<ulong>(nameof(MatchAllKeyword)); set => WriteHere(nameof(MatchAllKeyword), value); }

        [Offset(32UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(36UL)]
        public uint IsEnabled { get => ReadHere<uint>(nameof(IsEnabled)); set => WriteHere(nameof(IsEnabled), value); }

        [Offset(40UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(41UL)]
        public byte Reserve { get => ReadHere<byte>(nameof(Reserve)); set => WriteHere(nameof(Reserve), value); }

        [Offset(42UL)]
        public ushort EnableBitsCount { get => ReadHere<ushort>(nameof(EnableBitsCount)); set => WriteHere(nameof(EnableBitsCount), value); }

        [Offset(48UL)]
        public IntPtr EnableBitMask { get => ReadHere<IntPtr>(nameof(EnableBitMask)); set => WriteHere(nameof(EnableBitMask), value); }

        [Offset(56UL)]
        public IntPtr EnableKeyWords { get => ReadHere<IntPtr>(nameof(EnableKeyWords)); set => WriteHere(nameof(EnableKeyWords), value); }

        [Offset(64UL)]
        public IntPtr EnableLevel { get => ReadHere<IntPtr>(nameof(EnableLevel)); set => WriteHere(nameof(EnableLevel), value); }

        public McgenTraceContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<McgenTraceContext>();
        }
    }
}