using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HANDLE_COUNT_DATABASE")]
    public sealed class ObjectHandleCountDatabase : DynamicStructure
    {
        [Offset(0UL)]
        public uint CountEntries { get => ReadHere<uint>(nameof(CountEntries)); set => WriteHere(nameof(CountEntries), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray HandleCountEntries { get => ReadStructure<DynamicArray>(nameof(HandleCountEntries)); set => WriteStructure(nameof(HandleCountEntries), value); }

        public ObjectHandleCountDatabase(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHandleCountDatabase>();
        }
    }
}