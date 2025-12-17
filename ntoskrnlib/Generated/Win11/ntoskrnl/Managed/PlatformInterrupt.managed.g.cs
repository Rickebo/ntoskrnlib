using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PLATFORM_INTERRUPT")]
    public sealed class PlatformInterrupt : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public byte InterruptType { get => ReadHere<byte>(nameof(InterruptType)); set => WriteHere(nameof(InterruptType), value); }

        [Offset(5UL)]
        public byte APICID { get => ReadHere<byte>(nameof(APICID)); set => WriteHere(nameof(APICID), value); }

        [Offset(6UL)]
        public byte ACPIEID { get => ReadHere<byte>(nameof(ACPIEID)); set => WriteHere(nameof(ACPIEID), value); }

        [Offset(7UL)]
        public byte IOSAPICVector { get => ReadHere<byte>(nameof(IOSAPICVector)); set => WriteHere(nameof(IOSAPICVector), value); }

        [Offset(8UL)]
        public uint GlobalVector { get => ReadHere<uint>(nameof(GlobalVector)); set => WriteHere(nameof(GlobalVector), value); }

        [Offset(12UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public PlatformInterrupt(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PlatformInterrupt>();
        }
    }
}