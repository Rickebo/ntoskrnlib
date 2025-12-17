using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_VALUE")]
    public sealed class CmKeyValue : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Signature { get => ReadHere<ushort>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(2UL)]
        public ushort NameLength { get => ReadHere<ushort>(nameof(NameLength)); set => WriteHere(nameof(NameLength), value); }

        [Offset(4UL)]
        public uint DataLength { get => ReadHere<uint>(nameof(DataLength)); set => WriteHere(nameof(DataLength), value); }

        [Offset(8UL)]
        public uint Data { get => ReadHere<uint>(nameof(Data)); set => WriteHere(nameof(Data), value); }

        [Offset(12UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(16UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(18UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(20UL)]
        [Length(1)]
        public DynamicArray Name { get => ReadStructure<DynamicArray>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        public CmKeyValue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeyValue>();
        }
    }
}