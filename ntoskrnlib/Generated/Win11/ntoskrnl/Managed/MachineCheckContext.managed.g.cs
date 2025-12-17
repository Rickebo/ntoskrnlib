using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MACHINE_CHECK_CONTEXT")]
    public sealed class MachineCheckContext : DynamicStructure
    {
        [Offset(0UL)]
        public MachineFrame MachineFrame { get => ReadStructure<MachineFrame>(nameof(MachineFrame)); set => WriteStructure(nameof(MachineFrame), value); }

        [Offset(40UL)]
        public ulong Rax { get => ReadHere<ulong>(nameof(Rax)); set => WriteHere(nameof(Rax), value); }

        [Offset(48UL)]
        public ulong Rcx { get => ReadHere<ulong>(nameof(Rcx)); set => WriteHere(nameof(Rcx), value); }

        [Offset(56UL)]
        public ulong Rdx { get => ReadHere<ulong>(nameof(Rdx)); set => WriteHere(nameof(Rdx), value); }

        [Offset(64UL)]
        public ulong GsBase { get => ReadHere<ulong>(nameof(GsBase)); set => WriteHere(nameof(GsBase), value); }

        [Offset(72UL)]
        public ulong Cr3 { get => ReadHere<ulong>(nameof(Cr3)); set => WriteHere(nameof(Cr3), value); }

        public MachineCheckContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MachineCheckContext>();
        }
    }
}