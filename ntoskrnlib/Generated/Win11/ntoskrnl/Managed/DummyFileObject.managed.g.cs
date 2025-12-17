using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DUMMY_FILE_OBJECT")]
    public sealed class DummyFileObject : DynamicStructure
    {
        [Offset(0UL)]
        public ObjectHeader ObjectHeader { get => ReadStructure<ObjectHeader>(nameof(ObjectHeader)); set => WriteStructure(nameof(ObjectHeader), value); }

        [Offset(56UL)]
        [Length(216)]
        public DynamicArray FileObjectBody { get => ReadStructure<DynamicArray>(nameof(FileObjectBody)); set => WriteStructure(nameof(FileObjectBody), value); }

        public DummyFileObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DummyFileObject>();
        }
    }
}