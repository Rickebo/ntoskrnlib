using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTMOBJECT_NAMESPACE_LINK")]
    public sealed class KtmobjectNamespaceLink : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedLinks Links { get => ReadStructure<RtlBalancedLinks>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(32UL)]
        public byte Expired { get => ReadHere<byte>(nameof(Expired)); set => WriteHere(nameof(Expired), value); }

        public KtmobjectNamespaceLink(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtmobjectNamespaceLink>();
        }
    }
}