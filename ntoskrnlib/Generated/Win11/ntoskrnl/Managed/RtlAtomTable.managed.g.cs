using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_ATOM_TABLE")]
    public sealed class RtlAtomTable : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public int ReferenceCount { get => ReadHere<int>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(8UL)]
        public ExPushLock PushLock { get => ReadStructure<ExPushLock>(nameof(PushLock)); set => WriteStructure(nameof(PushLock), value); }

        [Offset(16UL)]
        public IntPtr ExHandleTable { get => ReadHere<IntPtr>(nameof(ExHandleTable)); set => WriteHere(nameof(ExHandleTable), value); }

        [Offset(24UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(28UL)]
        public uint NumberOfBuckets { get => ReadHere<uint>(nameof(NumberOfBuckets)); set => WriteHere(nameof(NumberOfBuckets), value); }

        [Offset(32UL)]
        [Length(1)]
        public DynamicArray Buckets { get => ReadStructure<DynamicArray>(nameof(Buckets)); set => WriteStructure(nameof(Buckets), value); }

        public RtlAtomTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlAtomTable>();
        }
    }
}