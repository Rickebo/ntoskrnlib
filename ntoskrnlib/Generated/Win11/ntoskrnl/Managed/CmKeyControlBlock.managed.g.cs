using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_CONTROL_BLOCK")]
    public sealed class CmKeyControlBlock : DynamicStructure
    {
        [Offset(0UL)]
        public ulong RefCount { get => ReadHere<ulong>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(8UL)]
        public uint ExtFlags { get => ReadHere<uint>(nameof(ExtFlags)); set => WriteHere(nameof(ExtFlags), value); }

        [Offset(8UL)]
        public uint Freed { get => ReadHere<uint>(nameof(Freed)); set => WriteHere(nameof(Freed), value); }

        [Offset(8UL)]
        public uint Discarded { get => ReadHere<uint>(nameof(Discarded)); set => WriteHere(nameof(Discarded), value); }

        [Offset(8UL)]
        public uint HiveUnloaded { get => ReadHere<uint>(nameof(HiveUnloaded)); set => WriteHere(nameof(HiveUnloaded), value); }

        [Offset(8UL)]
        public uint Decommissioned { get => ReadHere<uint>(nameof(Decommissioned)); set => WriteHere(nameof(Decommissioned), value); }

        [Offset(8UL)]
        public uint SpareExtFlag { get => ReadHere<uint>(nameof(SpareExtFlag)); set => WriteHere(nameof(SpareExtFlag), value); }

        [Offset(8UL)]
        public uint TotalLevels { get => ReadHere<uint>(nameof(TotalLevels)); set => WriteHere(nameof(TotalLevels), value); }

        [Offset(16UL)]
        public CmKeyHash KeyHash { get => ReadStructure<CmKeyHash>(nameof(KeyHash)); set => WriteStructure(nameof(KeyHash), value); }

        [Offset(16UL)]
        public CmPathHash ConvKey { get => ReadStructure<CmPathHash>(nameof(ConvKey)); set => WriteStructure(nameof(ConvKey), value); }

        [Offset(24UL)]
        public IntPtr NextHash { get => ReadHere<IntPtr>(nameof(NextHash)); set => WriteHere(nameof(NextHash), value); }

        [Offset(32UL)]
        public IntPtr KeyHive { get => ReadHere<IntPtr>(nameof(KeyHive)); set => WriteHere(nameof(KeyHive), value); }

        [Offset(40UL)]
        public uint KeyCell { get => ReadHere<uint>(nameof(KeyCell)); set => WriteHere(nameof(KeyCell), value); }

        [Offset(48UL)]
        public ExPushLock KcbPushlock { get => ReadStructure<ExPushLock>(nameof(KcbPushlock)); set => WriteStructure(nameof(KcbPushlock), value); }

        [Offset(56UL)]
        public IntPtr Owner { get => ReadHere<IntPtr>(nameof(Owner)); set => WriteHere(nameof(Owner), value); }

        [Offset(56UL)]
        public int SharedCount { get => ReadHere<int>(nameof(SharedCount)); set => WriteHere(nameof(SharedCount), value); }

        [Offset(64UL)]
        public byte DelayedDeref { get => ReadHere<byte>(nameof(DelayedDeref)); set => WriteHere(nameof(DelayedDeref), value); }

        [Offset(64UL)]
        public byte DelayedClose { get => ReadHere<byte>(nameof(DelayedClose)); set => WriteHere(nameof(DelayedClose), value); }

        [Offset(64UL)]
        public byte Parking { get => ReadHere<byte>(nameof(Parking)); set => WriteHere(nameof(Parking), value); }

        [Offset(65UL)]
        public byte LayerSemantics { get => ReadHere<byte>(nameof(LayerSemantics)); set => WriteHere(nameof(LayerSemantics), value); }

        [Offset(66UL)]
        public short LayerHeight { get => ReadHere<short>(nameof(LayerHeight)); set => WriteHere(nameof(LayerHeight), value); }

        [Offset(68UL)]
        public uint Spare1 { get => ReadHere<uint>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(72UL)]
        public IntPtr ParentKcb { get => ReadHere<IntPtr>(nameof(ParentKcb)); set => WriteHere(nameof(ParentKcb), value); }

        [Offset(80UL)]
        public IntPtr NameBlock { get => ReadHere<IntPtr>(nameof(NameBlock)); set => WriteHere(nameof(NameBlock), value); }

        [Offset(88UL)]
        public IntPtr CachedSecurity { get => ReadHere<IntPtr>(nameof(CachedSecurity)); set => WriteHere(nameof(CachedSecurity), value); }

        [Offset(96UL)]
        public ChildList ValueList { get => ReadStructure<ChildList>(nameof(ValueList)); set => WriteStructure(nameof(ValueList), value); }

        [Offset(104UL)]
        public IntPtr LinkTarget { get => ReadHere<IntPtr>(nameof(LinkTarget)); set => WriteHere(nameof(LinkTarget), value); }

        [Offset(112UL)]
        public IntPtr IndexHint { get => ReadHere<IntPtr>(nameof(IndexHint)); set => WriteHere(nameof(IndexHint), value); }

        [Offset(112UL)]
        public uint HashKey { get => ReadHere<uint>(nameof(HashKey)); set => WriteHere(nameof(HashKey), value); }

        [Offset(112UL)]
        public uint SubKeyCount { get => ReadHere<uint>(nameof(SubKeyCount)); set => WriteHere(nameof(SubKeyCount), value); }

        [Offset(120UL)]
        public ListEntry KeyBodyListHead { get => ReadStructure<ListEntry>(nameof(KeyBodyListHead)); set => WriteStructure(nameof(KeyBodyListHead), value); }

        [Offset(120UL)]
        public ListEntry ClonedListEntry { get => ReadStructure<ListEntry>(nameof(ClonedListEntry)); set => WriteStructure(nameof(ClonedListEntry), value); }

        [Offset(136UL)]
        [Length(4)]
        public DynamicArray KeyBodyArray { get => ReadStructure<DynamicArray>(nameof(KeyBodyArray)); set => WriteStructure(nameof(KeyBodyArray), value); }

        [Offset(168UL)]
        public LargeInteger KcbLastWriteTime { get => ReadStructure<LargeInteger>(nameof(KcbLastWriteTime)); set => WriteStructure(nameof(KcbLastWriteTime), value); }

        [Offset(176UL)]
        public ushort KcbMaxNameLen { get => ReadHere<ushort>(nameof(KcbMaxNameLen)); set => WriteHere(nameof(KcbMaxNameLen), value); }

        [Offset(178UL)]
        public ushort KcbMaxValueNameLen { get => ReadHere<ushort>(nameof(KcbMaxValueNameLen)); set => WriteHere(nameof(KcbMaxValueNameLen), value); }

        [Offset(180UL)]
        public uint KcbMaxValueDataLen { get => ReadHere<uint>(nameof(KcbMaxValueDataLen)); set => WriteHere(nameof(KcbMaxValueDataLen), value); }

        [Offset(184UL)]
        public uint KcbUserFlags { get => ReadHere<uint>(nameof(KcbUserFlags)); set => WriteHere(nameof(KcbUserFlags), value); }

        [Offset(184UL)]
        public uint KcbVirtControlFlags { get => ReadHere<uint>(nameof(KcbVirtControlFlags)); set => WriteHere(nameof(KcbVirtControlFlags), value); }

        [Offset(184UL)]
        public uint KcbDebug { get => ReadHere<uint>(nameof(KcbDebug)); set => WriteHere(nameof(KcbDebug), value); }

        [Offset(184UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(188UL)]
        public uint Spare3 { get => ReadHere<uint>(nameof(Spare3)); set => WriteHere(nameof(Spare3), value); }

        [Offset(192UL)]
        public IntPtr LayerInfo { get => ReadHere<IntPtr>(nameof(LayerInfo)); set => WriteHere(nameof(LayerInfo), value); }

        [Offset(200UL)]
        public IntPtr RealKeyName { get => ReadHere<IntPtr>(nameof(RealKeyName)); set => WriteHere(nameof(RealKeyName), value); }

        [Offset(208UL)]
        public ListEntry KCBUoWListHead { get => ReadStructure<ListEntry>(nameof(KCBUoWListHead)); set => WriteStructure(nameof(KCBUoWListHead), value); }

        [Offset(224UL)]
        public ListEntry DelayQueueEntry { get => ReadStructure<ListEntry>(nameof(DelayQueueEntry)); set => WriteStructure(nameof(DelayQueueEntry), value); }

        [Offset(224UL)]
        public IntPtr Stolen { get => ReadHere<IntPtr>(nameof(Stolen)); set => WriteHere(nameof(Stolen), value); }

        [Offset(240UL)]
        public IntPtr TransKCBOwner { get => ReadHere<IntPtr>(nameof(TransKCBOwner)); set => WriteHere(nameof(TransKCBOwner), value); }

        [Offset(248UL)]
        public CmIntentLock KCBLock { get => ReadStructure<CmIntentLock>(nameof(KCBLock)); set => WriteStructure(nameof(KCBLock), value); }

        [Offset(264UL)]
        public CmIntentLock KeyLock { get => ReadStructure<CmIntentLock>(nameof(KeyLock)); set => WriteStructure(nameof(KeyLock), value); }

        [Offset(280UL)]
        public ChildList TransValueCache { get => ReadStructure<ChildList>(nameof(TransValueCache)); set => WriteStructure(nameof(TransValueCache), value); }

        [Offset(288UL)]
        public IntPtr TransValueListOwner { get => ReadHere<IntPtr>(nameof(TransValueListOwner)); set => WriteHere(nameof(TransValueListOwner), value); }

        [Offset(296UL)]
        public IntPtr FullKCBName { get => ReadHere<IntPtr>(nameof(FullKCBName)); set => WriteHere(nameof(FullKCBName), value); }

        [Offset(296UL)]
        public ulong FullKCBNameStale { get => ReadHere<ulong>(nameof(FullKCBNameStale)); set => WriteHere(nameof(FullKCBNameStale), value); }

        [Offset(296UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(304UL)]
        public ulong SequenceNumber { get => ReadHere<ulong>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        public CmKeyControlBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeyControlBlock>();
        }
    }
}