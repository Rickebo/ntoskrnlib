using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BCB")]
    public sealed class Bcb : DynamicStructure
    {
        [Offset(0UL)]
        public Mbcb Dummy { get => ReadStructure<Mbcb>(nameof(Dummy)); set => WriteStructure(nameof(Dummy), value); }

        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public byte Dirty { get => ReadHere<byte>(nameof(Dirty)); set => WriteHere(nameof(Dirty), value); }

        [Offset(3UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint ByteLength { get => ReadHere<uint>(nameof(ByteLength)); set => WriteHere(nameof(ByteLength), value); }

        [Offset(8UL)]
        public LargeInteger FileOffset { get => ReadStructure<LargeInteger>(nameof(FileOffset)); set => WriteStructure(nameof(FileOffset), value); }

        [Offset(16UL)]
        public ListEntry BcbLinks { get => ReadStructure<ListEntry>(nameof(BcbLinks)); set => WriteStructure(nameof(BcbLinks), value); }

        [Offset(32UL)]
        public LargeInteger BeyondLastByte { get => ReadStructure<LargeInteger>(nameof(BeyondLastByte)); set => WriteStructure(nameof(BeyondLastByte), value); }

        [Offset(40UL)]
        public LargeInteger OldestLsn { get => ReadStructure<LargeInteger>(nameof(OldestLsn)); set => WriteStructure(nameof(OldestLsn), value); }

        [Offset(48UL)]
        public LargeInteger NewestLsn { get => ReadStructure<LargeInteger>(nameof(NewestLsn)); set => WriteStructure(nameof(NewestLsn), value); }

        [Offset(56UL)]
        public IntPtr Vacb { get => ReadHere<IntPtr>(nameof(Vacb)); set => WriteHere(nameof(Vacb), value); }

        [Offset(64UL)]
        public uint PinCount { get => ReadHere<uint>(nameof(PinCount)); set => WriteHere(nameof(PinCount), value); }

        [Offset(72UL)]
        public Eresource Resource { get => ReadStructure<Eresource>(nameof(Resource)); set => WriteStructure(nameof(Resource), value); }

        [Offset(176UL)]
        public IntPtr SharedCacheMap { get => ReadHere<IntPtr>(nameof(SharedCacheMap)); set => WriteHere(nameof(SharedCacheMap), value); }

        [Offset(184UL)]
        public IntPtr BaseAddress { get => ReadHere<IntPtr>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        public Bcb(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Bcb>();
        }
    }
}