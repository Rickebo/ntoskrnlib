using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_DEBUGGER_STATE")]
    public sealed class MiDebuggerState : DynamicStructure
    {
        [Offset(0UL)]
        public byte TransientWrite { get => ReadHere<byte>(nameof(TransientWrite)); set => WriteHere(nameof(TransientWrite), value); }

        [Offset(8UL)]
        [Length(2)]
        public DynamicArray DebugPtes { get => ReadStructure<DynamicArray>(nameof(DebugPtes)); set => WriteStructure(nameof(DebugPtes), value); }

        [Offset(24UL)]
        public uint PoisonedTb { get => ReadHere<uint>(nameof(PoisonedTb)); set => WriteHere(nameof(PoisonedTb), value); }

        [Offset(28UL)]
        public int InDebugger { get => ReadHere<int>(nameof(InDebugger)); set => WriteHere(nameof(InDebugger), value); }

        [Offset(32UL)]
        [Length(32)]
        public DynamicArray Pfns { get => ReadStructure<DynamicArray>(nameof(Pfns)); set => WriteStructure(nameof(Pfns), value); }

        [Offset(288UL)]
        [Length(256)]
        public DynamicArray PatchBuffer { get => ReadStructure<DynamicArray>(nameof(PatchBuffer)); set => WriteStructure(nameof(PatchBuffer), value); }

        [Offset(6432UL)]
        public uint PatchBufferInsertIndex { get => ReadHere<uint>(nameof(PatchBufferInsertIndex)); set => WriteHere(nameof(PatchBufferInsertIndex), value); }

        [Offset(6436UL)]
        public uint PatchBufferRemoveIndex { get => ReadHere<uint>(nameof(PatchBufferRemoveIndex)); set => WriteHere(nameof(PatchBufferRemoveIndex), value); }

        [Offset(6440UL)]
        [Length(512)]
        public DynamicArray PatchTableSpace { get => ReadStructure<DynamicArray>(nameof(PatchTableSpace)); set => WriteStructure(nameof(PatchTableSpace), value); }

        [Offset(18728UL)]
        [Length(512)]
        public DynamicArray PatchTable { get => ReadStructure<DynamicArray>(nameof(PatchTable)); set => WriteStructure(nameof(PatchTable), value); }

        [Offset(22824UL)]
        public int PatchTableLock { get => ReadHere<int>(nameof(PatchTableLock)); set => WriteHere(nameof(PatchTableLock), value); }

        [Offset(22828UL)]
        public uint PatchTableFreeEntry { get => ReadHere<uint>(nameof(PatchTableFreeEntry)); set => WriteHere(nameof(PatchTableFreeEntry), value); }

        [Offset(22832UL)]
        public uint PatchTableEntryCount { get => ReadHere<uint>(nameof(PatchTableEntryCount)); set => WriteHere(nameof(PatchTableEntryCount), value); }

        public MiDebuggerState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiDebuggerState>();
        }
    }
}