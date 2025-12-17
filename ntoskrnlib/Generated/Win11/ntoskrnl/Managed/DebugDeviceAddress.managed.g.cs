using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!DEBUG_DEVICE_ADDRESS")]
    public sealed class DebugDeviceAddress : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Valid { get => ReadHere<byte>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        [Offset(2UL)]
        [Length(2)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(2UL)]
        public byte BitWidth { get => ReadHere<byte>(nameof(BitWidth)); set => WriteHere(nameof(BitWidth), value); }

        [Offset(3UL)]
        public byte AccessSize { get => ReadHere<byte>(nameof(AccessSize)); set => WriteHere(nameof(AccessSize), value); }

        [Offset(8UL)]
        public IntPtr TranslatedAddress { get => ReadHere<IntPtr>(nameof(TranslatedAddress)); set => WriteHere(nameof(TranslatedAddress), value); }

        [Offset(16UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        public DebugDeviceAddress(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DebugDeviceAddress>();
        }
    }
}