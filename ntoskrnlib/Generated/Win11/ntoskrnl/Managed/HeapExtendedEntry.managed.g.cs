using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_EXTENDED_ENTRY")]
    public sealed class HeapExtendedEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Reserved { get => ReadHere<IntPtr>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public ushort FunctionIndex { get => ReadHere<ushort>(nameof(FunctionIndex)); set => WriteHere(nameof(FunctionIndex), value); }

        [Offset(10UL)]
        public ushort ContextValue { get => ReadHere<ushort>(nameof(ContextValue)); set => WriteHere(nameof(ContextValue), value); }

        [Offset(8UL)]
        public uint InterceptorValue { get => ReadHere<uint>(nameof(InterceptorValue)); set => WriteHere(nameof(InterceptorValue), value); }

        [Offset(12UL)]
        public ushort UnusedBytesLength { get => ReadHere<ushort>(nameof(UnusedBytesLength)); set => WriteHere(nameof(UnusedBytesLength), value); }

        [Offset(14UL)]
        public byte EntryOffset { get => ReadHere<byte>(nameof(EntryOffset)); set => WriteHere(nameof(EntryOffset), value); }

        [Offset(15UL)]
        public byte ExtendedBlockSignature { get => ReadHere<byte>(nameof(ExtendedBlockSignature)); set => WriteHere(nameof(ExtendedBlockSignature), value); }

        public HeapExtendedEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapExtendedEntry>();
        }
    }
}