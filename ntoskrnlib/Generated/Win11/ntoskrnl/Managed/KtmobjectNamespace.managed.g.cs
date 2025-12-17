using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTMOBJECT_NAMESPACE")]
    public sealed class KtmobjectNamespace : DynamicStructure
    {
        [Offset(0UL)]
        public RtlAvlTable Table { get => ReadStructure<RtlAvlTable>(nameof(Table)); set => WriteStructure(nameof(Table), value); }

        [Offset(104UL)]
        public Kmutant Mutex { get => ReadStructure<Kmutant>(nameof(Mutex)); set => WriteStructure(nameof(Mutex), value); }

        [Offset(160UL)]
        public ushort LinksOffset { get => ReadHere<ushort>(nameof(LinksOffset)); set => WriteHere(nameof(LinksOffset), value); }

        [Offset(162UL)]
        public ushort GuidOffset { get => ReadHere<ushort>(nameof(GuidOffset)); set => WriteHere(nameof(GuidOffset), value); }

        [Offset(164UL)]
        public byte Expired { get => ReadHere<byte>(nameof(Expired)); set => WriteHere(nameof(Expired), value); }

        public KtmobjectNamespace(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtmobjectNamespace>();
        }
    }
}