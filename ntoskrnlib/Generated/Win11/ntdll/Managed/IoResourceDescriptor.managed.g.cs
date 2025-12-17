using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IO_RESOURCE_DESCRIPTOR")]
    public sealed class IoResourceDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public byte Option { get => ReadHere<byte>(nameof(Option)); set => WriteHere(nameof(Option), value); }

        [Offset(1UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public byte ShareDisposition { get => ReadHere<byte>(nameof(ShareDisposition)); set => WriteHere(nameof(ShareDisposition), value); }

        [Offset(3UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(4UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(6UL)]
        public ushort Spare2 { get => ReadHere<ushort>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        [Offset(8UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public IoResourceDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoResourceDescriptor>();
        }
    }
}