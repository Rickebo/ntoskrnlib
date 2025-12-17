using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WMI_BUFFER_HEADER")]
    public sealed class WmiBufferHeader : DynamicStructure
    {
        [Offset(0UL)]
        public uint BufferSize { get => ReadHere<uint>(nameof(BufferSize)); set => WriteHere(nameof(BufferSize), value); }

        [Offset(4UL)]
        public uint SavedOffset { get => ReadHere<uint>(nameof(SavedOffset)); set => WriteHere(nameof(SavedOffset), value); }

        [Offset(8UL)]
        public uint CurrentOffset { get => ReadHere<uint>(nameof(CurrentOffset)); set => WriteHere(nameof(CurrentOffset), value); }

        [Offset(12UL)]
        public int ReferenceCount { get => ReadHere<int>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(16UL)]
        public LargeInteger TimeStamp { get => ReadStructure<LargeInteger>(nameof(TimeStamp)); set => WriteStructure(nameof(TimeStamp), value); }

        [Offset(24UL)]
        public long SequenceNumber { get => ReadHere<long>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        [Offset(32UL)]
        public ulong ClockType { get => ReadHere<ulong>(nameof(ClockType)); set => WriteHere(nameof(ClockType), value); }

        [Offset(32UL)]
        public ulong Frequency { get => ReadHere<ulong>(nameof(Frequency)); set => WriteHere(nameof(Frequency), value); }

        [Offset(32UL)]
        public SingleListEntry SlistEntry { get => ReadStructure<SingleListEntry>(nameof(SlistEntry)); set => WriteStructure(nameof(SlistEntry), value); }

        [Offset(32UL)]
        public IntPtr NextBuffer { get => ReadHere<IntPtr>(nameof(NextBuffer)); set => WriteHere(nameof(NextBuffer), value); }

        [Offset(40UL)]
        public EtwBufferContext ClientContext { get => ReadStructure<EtwBufferContext>(nameof(ClientContext)); set => WriteStructure(nameof(ClientContext), value); }

        [Offset(44UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(48UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(52UL)]
        public ushort BufferFlag { get => ReadHere<ushort>(nameof(BufferFlag)); set => WriteHere(nameof(BufferFlag), value); }

        [Offset(54UL)]
        public ushort BufferType { get => ReadHere<ushort>(nameof(BufferType)); set => WriteHere(nameof(BufferType), value); }

        [Offset(56UL)]
        [Length(4)]
        public DynamicArray Padding1 { get => ReadStructure<DynamicArray>(nameof(Padding1)); set => WriteStructure(nameof(Padding1), value); }

        [Offset(56UL)]
        public EtwRefClock ReferenceTime { get => ReadStructure<EtwRefClock>(nameof(ReferenceTime)); set => WriteStructure(nameof(ReferenceTime), value); }

        [Offset(56UL)]
        public ListEntry GlobalEntry { get => ReadStructure<ListEntry>(nameof(GlobalEntry)); set => WriteStructure(nameof(GlobalEntry), value); }

        [Offset(56UL)]
        public IntPtr Pointer0 { get => ReadHere<IntPtr>(nameof(Pointer0)); set => WriteHere(nameof(Pointer0), value); }

        [Offset(64UL)]
        public IntPtr Pointer1 { get => ReadHere<IntPtr>(nameof(Pointer1)); set => WriteHere(nameof(Pointer1), value); }

        public WmiBufferHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WmiBufferHeader>();
        }
    }
}