using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_GENERIC_ERROR_DESCRIPTOR")]
    public sealed class WheaGenericErrorDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(3UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(4UL)]
        public uint ErrStatusBlockLength { get => ReadHere<uint>(nameof(ErrStatusBlockLength)); set => WriteHere(nameof(ErrStatusBlockLength), value); }

        [Offset(8UL)]
        public uint RelatedErrorSourceId { get => ReadHere<uint>(nameof(RelatedErrorSourceId)); set => WriteHere(nameof(RelatedErrorSourceId), value); }

        [Offset(12UL)]
        public byte ErrStatusAddressSpaceID { get => ReadHere<byte>(nameof(ErrStatusAddressSpaceID)); set => WriteHere(nameof(ErrStatusAddressSpaceID), value); }

        [Offset(13UL)]
        public byte ErrStatusAddressBitWidth { get => ReadHere<byte>(nameof(ErrStatusAddressBitWidth)); set => WriteHere(nameof(ErrStatusAddressBitWidth), value); }

        [Offset(14UL)]
        public byte ErrStatusAddressBitOffset { get => ReadHere<byte>(nameof(ErrStatusAddressBitOffset)); set => WriteHere(nameof(ErrStatusAddressBitOffset), value); }

        [Offset(15UL)]
        public byte ErrStatusAddressAccessSize { get => ReadHere<byte>(nameof(ErrStatusAddressAccessSize)); set => WriteHere(nameof(ErrStatusAddressAccessSize), value); }

        [Offset(16UL)]
        public LargeInteger ErrStatusAddress { get => ReadStructure<LargeInteger>(nameof(ErrStatusAddress)); set => WriteStructure(nameof(ErrStatusAddress), value); }

        [Offset(24UL)]
        public WheaNotificationDescriptor Notify { get => ReadStructure<WheaNotificationDescriptor>(nameof(Notify)); set => WriteStructure(nameof(Notify), value); }

        public WheaGenericErrorDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaGenericErrorDescriptor>();
        }
    }
}