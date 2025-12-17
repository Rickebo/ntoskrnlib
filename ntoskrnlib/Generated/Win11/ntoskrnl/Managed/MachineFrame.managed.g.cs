using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MACHINE_FRAME")]
    public sealed class MachineFrame : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Rip { get => ReadHere<ulong>(nameof(Rip)); set => WriteHere(nameof(Rip), value); }

        [Offset(8UL)]
        public ushort SegCs { get => ReadHere<ushort>(nameof(SegCs)); set => WriteHere(nameof(SegCs), value); }

        [Offset(10UL)]
        [Length(3)]
        public DynamicArray Fill1 { get => ReadStructure<DynamicArray>(nameof(Fill1)); set => WriteStructure(nameof(Fill1), value); }

        [Offset(16UL)]
        public uint EFlags { get => ReadHere<uint>(nameof(EFlags)); set => WriteHere(nameof(EFlags), value); }

        [Offset(20UL)]
        public uint Fill2 { get => ReadHere<uint>(nameof(Fill2)); set => WriteHere(nameof(Fill2), value); }

        [Offset(24UL)]
        public ulong Rsp { get => ReadHere<ulong>(nameof(Rsp)); set => WriteHere(nameof(Rsp), value); }

        [Offset(32UL)]
        public ushort SegSs { get => ReadHere<ushort>(nameof(SegSs)); set => WriteHere(nameof(SegSs), value); }

        [Offset(34UL)]
        [Length(3)]
        public DynamicArray Fill3 { get => ReadStructure<DynamicArray>(nameof(Fill3)); set => WriteStructure(nameof(Fill3), value); }

        public MachineFrame(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MachineFrame>();
        }
    }
}