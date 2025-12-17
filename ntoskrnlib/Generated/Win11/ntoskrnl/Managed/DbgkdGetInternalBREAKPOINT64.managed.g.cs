using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_INTERNAL_BREAKPOINT64")]
    public sealed class DbgkdGetInternalBREAKPOINT64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BreakpointAddress { get => ReadHere<ulong>(nameof(BreakpointAddress)); set => WriteHere(nameof(BreakpointAddress), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(12UL)]
        public uint Calls { get => ReadHere<uint>(nameof(Calls)); set => WriteHere(nameof(Calls), value); }

        [Offset(16UL)]
        public uint MaxCallsPerPeriod { get => ReadHere<uint>(nameof(MaxCallsPerPeriod)); set => WriteHere(nameof(MaxCallsPerPeriod), value); }

        [Offset(20UL)]
        public uint MinInstructions { get => ReadHere<uint>(nameof(MinInstructions)); set => WriteHere(nameof(MinInstructions), value); }

        [Offset(24UL)]
        public uint MaxInstructions { get => ReadHere<uint>(nameof(MaxInstructions)); set => WriteHere(nameof(MaxInstructions), value); }

        [Offset(28UL)]
        public uint TotalInstructions { get => ReadHere<uint>(nameof(TotalInstructions)); set => WriteHere(nameof(TotalInstructions), value); }

        public DbgkdGetInternalBREAKPOINT64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdGetInternalBREAKPOINT64>();
        }
    }
}