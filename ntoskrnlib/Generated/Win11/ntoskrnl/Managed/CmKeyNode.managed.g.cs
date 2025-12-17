using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_NODE")]
    public sealed class CmKeyNode : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Signature { get => ReadHere<ushort>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(2UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public LargeInteger LastWriteTime { get => ReadStructure<LargeInteger>(nameof(LastWriteTime)); set => WriteStructure(nameof(LastWriteTime), value); }

        [Offset(12UL)]
        public byte AccessBits { get => ReadHere<byte>(nameof(AccessBits)); set => WriteHere(nameof(AccessBits), value); }

        [Offset(13UL)]
        public byte LayerSemantics { get => ReadHere<byte>(nameof(LayerSemantics)); set => WriteHere(nameof(LayerSemantics), value); }

        [Offset(13UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(13UL)]
        public byte InheritClass { get => ReadHere<byte>(nameof(InheritClass)); set => WriteHere(nameof(InheritClass), value); }

        [Offset(14UL)]
        public ushort Spare2 { get => ReadHere<ushort>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        [Offset(16UL)]
        public uint Parent { get => ReadHere<uint>(nameof(Parent)); set => WriteHere(nameof(Parent), value); }

        [Offset(20UL)]
        [Length(2)]
        public DynamicArray SubKeyCounts { get => ReadStructure<DynamicArray>(nameof(SubKeyCounts)); set => WriteStructure(nameof(SubKeyCounts), value); }

        [Offset(28UL)]
        [Length(2)]
        public DynamicArray SubKeyLists { get => ReadStructure<DynamicArray>(nameof(SubKeyLists)); set => WriteStructure(nameof(SubKeyLists), value); }

        [Offset(36UL)]
        public ChildList ValueList { get => ReadStructure<ChildList>(nameof(ValueList)); set => WriteStructure(nameof(ValueList), value); }

        [Offset(28UL)]
        public CmKeyReference ChildHiveReference { get => ReadStructure<CmKeyReference>(nameof(ChildHiveReference)); set => WriteStructure(nameof(ChildHiveReference), value); }

        [Offset(44UL)]
        public uint Security { get => ReadHere<uint>(nameof(Security)); set => WriteHere(nameof(Security), value); }

        [Offset(48UL)]
        public uint Class { get => ReadHere<uint>(nameof(Class)); set => WriteHere(nameof(Class), value); }

        [Offset(52UL)]
        public uint MaxNameLen { get => ReadHere<uint>(nameof(MaxNameLen)); set => WriteHere(nameof(MaxNameLen), value); }

        [Offset(52UL)]
        public uint UserFlags { get => ReadHere<uint>(nameof(UserFlags)); set => WriteHere(nameof(UserFlags), value); }

        [Offset(52UL)]
        public uint VirtControlFlags { get => ReadHere<uint>(nameof(VirtControlFlags)); set => WriteHere(nameof(VirtControlFlags), value); }

        [Offset(52UL)]
        public uint Debug { get => ReadHere<uint>(nameof(Debug)); set => WriteHere(nameof(Debug), value); }

        [Offset(56UL)]
        public uint MaxClassLen { get => ReadHere<uint>(nameof(MaxClassLen)); set => WriteHere(nameof(MaxClassLen), value); }

        [Offset(60UL)]
        public uint MaxValueNameLen { get => ReadHere<uint>(nameof(MaxValueNameLen)); set => WriteHere(nameof(MaxValueNameLen), value); }

        [Offset(64UL)]
        public uint MaxValueDataLen { get => ReadHere<uint>(nameof(MaxValueDataLen)); set => WriteHere(nameof(MaxValueDataLen), value); }

        [Offset(68UL)]
        public uint WorkVar { get => ReadHere<uint>(nameof(WorkVar)); set => WriteHere(nameof(WorkVar), value); }

        [Offset(72UL)]
        public ushort NameLength { get => ReadHere<ushort>(nameof(NameLength)); set => WriteHere(nameof(NameLength), value); }

        [Offset(74UL)]
        public ushort ClassLength { get => ReadHere<ushort>(nameof(ClassLength)); set => WriteHere(nameof(ClassLength), value); }

        [Offset(76UL)]
        [Length(1)]
        public DynamicArray Name { get => ReadStructure<DynamicArray>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        public CmKeyNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeyNode>();
        }
    }
}