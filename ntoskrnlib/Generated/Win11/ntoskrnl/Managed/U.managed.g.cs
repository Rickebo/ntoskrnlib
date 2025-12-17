using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_u")]
    public sealed class U : DynamicStructure
    {
        [Offset(0UL)]
        public CmKeyNode KeyNode { get => ReadStructure<CmKeyNode>(nameof(KeyNode)); set => WriteStructure(nameof(KeyNode), value); }

        [Offset(0UL)]
        public CmKeyValue KeyValue { get => ReadStructure<CmKeyValue>(nameof(KeyValue)); set => WriteStructure(nameof(KeyValue), value); }

        [Offset(0UL)]
        public CmKeySecurity KeySecurity { get => ReadStructure<CmKeySecurity>(nameof(KeySecurity)); set => WriteStructure(nameof(KeySecurity), value); }

        [Offset(0UL)]
        public CmKeyIndex KeyIndex { get => ReadStructure<CmKeyIndex>(nameof(KeyIndex)); set => WriteStructure(nameof(KeyIndex), value); }

        [Offset(0UL)]
        public CmBigData ValueData { get => ReadStructure<CmBigData>(nameof(ValueData)); set => WriteStructure(nameof(ValueData), value); }

        [Offset(0UL)]
        [Length(1)]
        public DynamicArray KeyList { get => ReadStructure<DynamicArray>(nameof(KeyList)); set => WriteStructure(nameof(KeyList), value); }

        [Offset(0UL)]
        [Length(1)]
        public DynamicArray KeyString { get => ReadStructure<DynamicArray>(nameof(KeyString)); set => WriteStructure(nameof(KeyString), value); }

        public U(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<U>();
        }
    }
}