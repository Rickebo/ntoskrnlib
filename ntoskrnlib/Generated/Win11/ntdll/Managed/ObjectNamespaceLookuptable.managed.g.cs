using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_OBJECT_NAMESPACE_LOOKUPTABLE")]
    public sealed class ObjectNamespaceLookuptable : DynamicStructure
    {
        [Offset(0UL)]
        [Length(37)]
        public DynamicArray HashBuckets { get => ReadStructure<DynamicArray>(nameof(HashBuckets)); set => WriteStructure(nameof(HashBuckets), value); }

        [Offset(592UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(600UL)]
        public uint NumberOfPrivateSpaces { get => ReadHere<uint>(nameof(NumberOfPrivateSpaces)); set => WriteHere(nameof(NumberOfPrivateSpaces), value); }

        public ObjectNamespaceLookuptable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectNamespaceLookuptable>();
        }
    }
}