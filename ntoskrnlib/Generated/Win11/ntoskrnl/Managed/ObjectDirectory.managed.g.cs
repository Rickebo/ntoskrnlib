using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_DIRECTORY")]
    public sealed class ObjectDirectory : DynamicStructure
    {
        [Offset(0UL)]
        [Length(37)]
        public DynamicArray HashBuckets { get => ReadStructure<DynamicArray>(nameof(HashBuckets)); set => WriteStructure(nameof(HashBuckets), value); }

        [Offset(296UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(304UL)]
        public IntPtr DeviceMap { get => ReadHere<IntPtr>(nameof(DeviceMap)); set => WriteHere(nameof(DeviceMap), value); }

        [Offset(312UL)]
        public IntPtr ShadowDirectory { get => ReadHere<IntPtr>(nameof(ShadowDirectory)); set => WriteHere(nameof(ShadowDirectory), value); }

        [Offset(320UL)]
        public IntPtr NamespaceEntry { get => ReadHere<IntPtr>(nameof(NamespaceEntry)); set => WriteHere(nameof(NamespaceEntry), value); }

        [Offset(328UL)]
        public IntPtr SessionObject { get => ReadHere<IntPtr>(nameof(SessionObject)); set => WriteHere(nameof(SessionObject), value); }

        [Offset(336UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(340UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        public ObjectDirectory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectDirectory>();
        }
    }
}