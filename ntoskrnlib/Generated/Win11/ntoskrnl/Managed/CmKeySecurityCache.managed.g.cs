using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_SECURITY_CACHE")]
    public sealed class CmKeySecurityCache : DynamicStructure
    {
        [Offset(0UL)]
        public uint Cell { get => ReadHere<uint>(nameof(Cell)); set => WriteHere(nameof(Cell), value); }

        [Offset(4UL)]
        public uint ConvKey { get => ReadHere<uint>(nameof(ConvKey)); set => WriteHere(nameof(ConvKey), value); }

        [Offset(8UL)]
        public ListEntry List { get => ReadStructure<ListEntry>(nameof(List)); set => WriteStructure(nameof(List), value); }

        [Offset(24UL)]
        public uint DescriptorLength { get => ReadHere<uint>(nameof(DescriptorLength)); set => WriteHere(nameof(DescriptorLength), value); }

        [Offset(28UL)]
        public uint RealRefCount { get => ReadHere<uint>(nameof(RealRefCount)); set => WriteHere(nameof(RealRefCount), value); }

        [Offset(32UL)]
        public SecurityDescriptorRelative Descriptor { get => ReadStructure<SecurityDescriptorRelative>(nameof(Descriptor)); set => WriteStructure(nameof(Descriptor), value); }

        public CmKeySecurityCache(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeySecurityCache>();
        }
    }
}