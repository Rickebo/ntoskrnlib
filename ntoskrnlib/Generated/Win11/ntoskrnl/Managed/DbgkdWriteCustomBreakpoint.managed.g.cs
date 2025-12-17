using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_WRITE_CUSTOM_BREAKPOINT")]
    public sealed class DbgkdWriteCustomBreakpoint : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BreakPointAddress { get => ReadHere<ulong>(nameof(BreakPointAddress)); set => WriteHere(nameof(BreakPointAddress), value); }

        [Offset(8UL)]
        public ulong BreakPointInstruction { get => ReadHere<ulong>(nameof(BreakPointInstruction)); set => WriteHere(nameof(BreakPointInstruction), value); }

        [Offset(16UL)]
        public uint BreakPointHandle { get => ReadHere<uint>(nameof(BreakPointHandle)); set => WriteHere(nameof(BreakPointHandle), value); }

        [Offset(20UL)]
        public byte BreakPointInstructionSize { get => ReadHere<byte>(nameof(BreakPointInstructionSize)); set => WriteHere(nameof(BreakPointInstructionSize), value); }

        [Offset(21UL)]
        public byte BreakPointInstructionAlignment { get => ReadHere<byte>(nameof(BreakPointInstructionAlignment)); set => WriteHere(nameof(BreakPointInstructionAlignment), value); }

        public DbgkdWriteCustomBreakpoint(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdWriteCustomBreakpoint>();
        }
    }
}