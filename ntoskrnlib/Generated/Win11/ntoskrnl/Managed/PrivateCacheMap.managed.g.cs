using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PRIVATE_CACHE_MAP")]
    public sealed class PrivateCacheMap : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(0UL)]
        public PrivateCacheMapFlags Flags { get => ReadStructure<PrivateCacheMapFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(4UL)]
        public uint ReadAheadMask { get => ReadHere<uint>(nameof(ReadAheadMask)); set => WriteHere(nameof(ReadAheadMask), value); }

        [Offset(8UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        [Offset(16UL)]
        public LargeInteger FileOffset1 { get => ReadStructure<LargeInteger>(nameof(FileOffset1)); set => WriteStructure(nameof(FileOffset1), value); }

        [Offset(24UL)]
        public LargeInteger BeyondLastByte1 { get => ReadStructure<LargeInteger>(nameof(BeyondLastByte1)); set => WriteStructure(nameof(BeyondLastByte1), value); }

        [Offset(32UL)]
        public LargeInteger FileOffset2 { get => ReadStructure<LargeInteger>(nameof(FileOffset2)); set => WriteStructure(nameof(FileOffset2), value); }

        [Offset(40UL)]
        public LargeInteger BeyondLastByte2 { get => ReadStructure<LargeInteger>(nameof(BeyondLastByte2)); set => WriteStructure(nameof(BeyondLastByte2), value); }

        [Offset(48UL)]
        public uint SequentialReadCount { get => ReadHere<uint>(nameof(SequentialReadCount)); set => WriteHere(nameof(SequentialReadCount), value); }

        [Offset(52UL)]
        public uint ReadAheadLength { get => ReadHere<uint>(nameof(ReadAheadLength)); set => WriteHere(nameof(ReadAheadLength), value); }

        [Offset(56UL)]
        public LargeInteger ReadAheadOffset { get => ReadStructure<LargeInteger>(nameof(ReadAheadOffset)); set => WriteStructure(nameof(ReadAheadOffset), value); }

        [Offset(64UL)]
        public LargeInteger ReadAheadBeyondLastByte { get => ReadStructure<LargeInteger>(nameof(ReadAheadBeyondLastByte)); set => WriteStructure(nameof(ReadAheadBeyondLastByte), value); }

        [Offset(72UL)]
        public ulong PrevReadAheadBeyondLastByte { get => ReadHere<ulong>(nameof(PrevReadAheadBeyondLastByte)); set => WriteHere(nameof(PrevReadAheadBeyondLastByte), value); }

        [Offset(80UL)]
        public ulong ReadAheadSpinLock { get => ReadHere<ulong>(nameof(ReadAheadSpinLock)); set => WriteHere(nameof(ReadAheadSpinLock), value); }

        [Offset(88UL)]
        public uint PipelinedReadAheadRequestSize { get => ReadHere<uint>(nameof(PipelinedReadAheadRequestSize)); set => WriteHere(nameof(PipelinedReadAheadRequestSize), value); }

        [Offset(92UL)]
        public uint ReadAheadGrowth { get => ReadHere<uint>(nameof(ReadAheadGrowth)); set => WriteHere(nameof(ReadAheadGrowth), value); }

        [Offset(96UL)]
        public ListEntry PrivateLinks { get => ReadStructure<ListEntry>(nameof(PrivateLinks)); set => WriteStructure(nameof(PrivateLinks), value); }

        [Offset(112UL)]
        public IntPtr ReadAheadWorkItem { get => ReadHere<IntPtr>(nameof(ReadAheadWorkItem)); set => WriteHere(nameof(ReadAheadWorkItem), value); }

        public PrivateCacheMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PrivateCacheMap>();
        }
    }
}