using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FSRTL_ADVANCED_FCB_HEADER")]
    public sealed class FsrtlAdvancedFcbHeader : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public short NodeByteSize { get => ReadHere<short>(nameof(NodeByteSize)); set => WriteHere(nameof(NodeByteSize), value); }

        [Offset(4UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(5UL)]
        public byte IsFastIoPossible { get => ReadHere<byte>(nameof(IsFastIoPossible)); set => WriteHere(nameof(IsFastIoPossible), value); }

        [Offset(6UL)]
        public byte Flags2 { get => ReadHere<byte>(nameof(Flags2)); set => WriteHere(nameof(Flags2), value); }

        [Offset(7UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(7UL)]
        public byte Version { get => ReadHere<byte>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr Resource { get => ReadHere<IntPtr>(nameof(Resource)); set => WriteHere(nameof(Resource), value); }

        [Offset(16UL)]
        public IntPtr PagingIoResource { get => ReadHere<IntPtr>(nameof(PagingIoResource)); set => WriteHere(nameof(PagingIoResource), value); }

        [Offset(24UL)]
        public LargeInteger AllocationSize { get => ReadStructure<LargeInteger>(nameof(AllocationSize)); set => WriteStructure(nameof(AllocationSize), value); }

        [Offset(32UL)]
        public LargeInteger FileSize { get => ReadStructure<LargeInteger>(nameof(FileSize)); set => WriteStructure(nameof(FileSize), value); }

        [Offset(40UL)]
        public LargeInteger ValidDataLength { get => ReadStructure<LargeInteger>(nameof(ValidDataLength)); set => WriteStructure(nameof(ValidDataLength), value); }

        [Offset(48UL)]
        public IntPtr FastMutex { get => ReadHere<IntPtr>(nameof(FastMutex)); set => WriteHere(nameof(FastMutex), value); }

        [Offset(56UL)]
        public ListEntry FilterContexts { get => ReadStructure<ListEntry>(nameof(FilterContexts)); set => WriteStructure(nameof(FilterContexts), value); }

        [Offset(72UL)]
        public ExPushLock PushLock { get => ReadStructure<ExPushLock>(nameof(PushLock)); set => WriteStructure(nameof(PushLock), value); }

        [Offset(80UL)]
        public IntPtr FileContextSupportPointer { get => ReadHere<IntPtr>(nameof(FileContextSupportPointer)); set => WriteHere(nameof(FileContextSupportPointer), value); }

        [Offset(88UL)]
        public IntPtr Oplock { get => ReadHere<IntPtr>(nameof(Oplock)); set => WriteHere(nameof(Oplock), value); }

        [Offset(88UL)]
        public IntPtr ReservedForRemote { get => ReadHere<IntPtr>(nameof(ReservedForRemote)); set => WriteHere(nameof(ReservedForRemote), value); }

        [Offset(96UL)]
        public IntPtr AePushLock { get => ReadHere<IntPtr>(nameof(AePushLock)); set => WriteHere(nameof(AePushLock), value); }

        [Offset(104UL)]
        public uint BypassIoOpenCount { get => ReadHere<uint>(nameof(BypassIoOpenCount)); set => WriteHere(nameof(BypassIoOpenCount), value); }

        [Offset(112UL)]
        public IntPtr ReservedContext { get => ReadHere<IntPtr>(nameof(ReservedContext)); set => WriteHere(nameof(ReservedContext), value); }

        public FsrtlAdvancedFcbHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FsrtlAdvancedFcbHeader>();
        }
    }
}