using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FACS")]
    public sealed class Facs : DynamicStructure
    {
        [Offset(0UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(4UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(8UL)]
        public uint HardwareSignature { get => ReadHere<uint>(nameof(HardwareSignature)); set => WriteHere(nameof(HardwareSignature), value); }

        [Offset(12UL)]
        public uint pFirmwareWakingVector { get => ReadHere<uint>(nameof(pFirmwareWakingVector)); set => WriteHere(nameof(pFirmwareWakingVector), value); }

        [Offset(16UL)]
        public uint GlobalLock { get => ReadHere<uint>(nameof(GlobalLock)); set => WriteHere(nameof(GlobalLock), value); }

        [Offset(20UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(24UL)]
        public LargeInteger x_FirmwareWakingVector { get => ReadStructure<LargeInteger>(nameof(x_FirmwareWakingVector)); set => WriteStructure(nameof(x_FirmwareWakingVector), value); }

        [Offset(32UL)]
        public byte version { get => ReadHere<byte>(nameof(version)); set => WriteHere(nameof(version), value); }

        [Offset(33UL)]
        [Length(31)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public Facs(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Facs>();
        }
    }
}