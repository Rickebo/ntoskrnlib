using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_REMOVE_LOCK_COMMON_BLOCK")]
    public sealed class IoRemoveLockCommonBlock : DynamicStructure
    {
        [Offset(0UL)]
        public byte Removed { get => ReadHere<byte>(nameof(Removed)); set => WriteHere(nameof(Removed), value); }

        [Offset(1UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(4UL)]
        public int IoCount { get => ReadHere<int>(nameof(IoCount)); set => WriteHere(nameof(IoCount), value); }

        [Offset(8UL)]
        public Kevent RemoveEvent { get => ReadStructure<Kevent>(nameof(RemoveEvent)); set => WriteStructure(nameof(RemoveEvent), value); }

        public IoRemoveLockCommonBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoRemoveLockCommonBlock>();
        }
    }
}