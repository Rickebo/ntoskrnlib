using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEFERRED_WRITE")]
    public sealed class DeferredWrite : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public short NodeByteSize { get => ReadHere<short>(nameof(NodeByteSize)); set => WriteHere(nameof(NodeByteSize), value); }

        [Offset(8UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        [Offset(16UL)]
        public uint BytesToWrite { get => ReadHere<uint>(nameof(BytesToWrite)); set => WriteHere(nameof(BytesToWrite), value); }

        [Offset(24UL)]
        public ListEntry DeferredWriteLinks { get => ReadStructure<ListEntry>(nameof(DeferredWriteLinks)); set => WriteStructure(nameof(DeferredWriteLinks), value); }

        [Offset(40UL)]
        public IntPtr Event { get => ReadHere<IntPtr>(nameof(Event)); set => WriteHere(nameof(Event), value); }

        [Offset(48UL)]
        public IntPtr PostRoutine { get => ReadHere<IntPtr>(nameof(PostRoutine)); set => WriteHere(nameof(PostRoutine), value); }

        [Offset(56UL)]
        public IntPtr Context1 { get => ReadHere<IntPtr>(nameof(Context1)); set => WriteHere(nameof(Context1), value); }

        [Offset(64UL)]
        public IntPtr Context2 { get => ReadHere<IntPtr>(nameof(Context2)); set => WriteHere(nameof(Context2), value); }

        [Offset(72UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(80UL)]
        public IntPtr PrivateVolumeCacheMap { get => ReadHere<IntPtr>(nameof(PrivateVolumeCacheMap)); set => WriteHere(nameof(PrivateVolumeCacheMap), value); }

        [Offset(88UL)]
        public byte SoftThrottle { get => ReadHere<byte>(nameof(SoftThrottle)); set => WriteHere(nameof(SoftThrottle), value); }

        [Offset(96UL)]
        public LargeInteger TimeAdded { get => ReadStructure<LargeInteger>(nameof(TimeAdded)); set => WriteStructure(nameof(TimeAdded), value); }

        public DeferredWrite(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeferredWrite>();
        }
    }
}