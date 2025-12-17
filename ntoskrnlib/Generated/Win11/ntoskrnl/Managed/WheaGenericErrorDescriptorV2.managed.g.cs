using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_GENERIC_ERROR_DESCRIPTOR_V2")]
    public sealed class WheaGenericErrorDescriptorV2 : DynamicStructure
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

        [Offset(52UL)]
        public byte ReadAckAddressSpaceID { get => ReadHere<byte>(nameof(ReadAckAddressSpaceID)); set => WriteHere(nameof(ReadAckAddressSpaceID), value); }

        [Offset(53UL)]
        public byte ReadAckAddressBitWidth { get => ReadHere<byte>(nameof(ReadAckAddressBitWidth)); set => WriteHere(nameof(ReadAckAddressBitWidth), value); }

        [Offset(54UL)]
        public byte ReadAckAddressBitOffset { get => ReadHere<byte>(nameof(ReadAckAddressBitOffset)); set => WriteHere(nameof(ReadAckAddressBitOffset), value); }

        [Offset(55UL)]
        public byte ReadAckAddressAccessSize { get => ReadHere<byte>(nameof(ReadAckAddressAccessSize)); set => WriteHere(nameof(ReadAckAddressAccessSize), value); }

        [Offset(56UL)]
        public LargeInteger ReadAckAddress { get => ReadStructure<LargeInteger>(nameof(ReadAckAddress)); set => WriteStructure(nameof(ReadAckAddress), value); }

        [Offset(64UL)]
        public ulong ReadAckPreserveMask { get => ReadHere<ulong>(nameof(ReadAckPreserveMask)); set => WriteHere(nameof(ReadAckPreserveMask), value); }

        [Offset(72UL)]
        public ulong ReadAckWriteMask { get => ReadHere<ulong>(nameof(ReadAckWriteMask)); set => WriteHere(nameof(ReadAckWriteMask), value); }

        public WheaGenericErrorDescriptorV2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaGenericErrorDescriptorV2>();
        }
    }
}