using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_HASH_BUCKET")]
    public sealed class EtwHashBucket : DynamicStructure
    {
        [Offset(0UL)]
        [Length(3)]
        public DynamicArray ListHead { get => ReadStructure<DynamicArray>(nameof(ListHead)); set => WriteStructure(nameof(ListHead), value); }

        [Offset(48UL)]
        public ExPushLock BucketLock { get => ReadStructure<ExPushLock>(nameof(BucketLock)); set => WriteStructure(nameof(BucketLock), value); }

        public EtwHashBucket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwHashBucket>();
        }
    }
}