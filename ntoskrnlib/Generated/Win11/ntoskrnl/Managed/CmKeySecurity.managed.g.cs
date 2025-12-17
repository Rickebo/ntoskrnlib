using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_SECURITY")]
    public sealed class CmKeySecurity : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Signature { get => ReadHere<ushort>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(2UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint Flink { get => ReadHere<uint>(nameof(Flink)); set => WriteHere(nameof(Flink), value); }

        [Offset(8UL)]
        public uint Blink { get => ReadHere<uint>(nameof(Blink)); set => WriteHere(nameof(Blink), value); }

        [Offset(12UL)]
        public uint ReferenceCount { get => ReadHere<uint>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(16UL)]
        public uint DescriptorLength { get => ReadHere<uint>(nameof(DescriptorLength)); set => WriteHere(nameof(DescriptorLength), value); }

        [Offset(20UL)]
        public SecurityDescriptorRelative Descriptor { get => ReadStructure<SecurityDescriptorRelative>(nameof(Descriptor)); set => WriteStructure(nameof(Descriptor), value); }

        public CmKeySecurity(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeySecurity>();
        }
    }
}