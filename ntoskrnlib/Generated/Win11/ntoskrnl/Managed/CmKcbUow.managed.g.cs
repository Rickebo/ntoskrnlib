using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KCB_UOW")]
    public sealed class CmKcbUow : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry TransactionListEntry { get => ReadStructure<ListEntry>(nameof(TransactionListEntry)); set => WriteStructure(nameof(TransactionListEntry), value); }

        [Offset(16UL)]
        public IntPtr KCBLock { get => ReadHere<IntPtr>(nameof(KCBLock)); set => WriteHere(nameof(KCBLock), value); }

        [Offset(24UL)]
        public IntPtr KeyLock { get => ReadHere<IntPtr>(nameof(KeyLock)); set => WriteHere(nameof(KeyLock), value); }

        [Offset(32UL)]
        public ListEntry KCBListEntry { get => ReadStructure<ListEntry>(nameof(KCBListEntry)); set => WriteStructure(nameof(KCBListEntry), value); }

        [Offset(48UL)]
        public IntPtr KeyControlBlock { get => ReadHere<IntPtr>(nameof(KeyControlBlock)); set => WriteHere(nameof(KeyControlBlock), value); }

        [Offset(56UL)]
        public IntPtr Transaction { get => ReadHere<IntPtr>(nameof(Transaction)); set => WriteHere(nameof(Transaction), value); }

        [Offset(64UL)]
        public uint UoWState { get => ReadHere<uint>(nameof(UoWState)); set => WriteHere(nameof(UoWState), value); }

        [Offset(68UL)]
        public uint ActionType { get => ReadHere<uint>(nameof(ActionType)); set => WriteHere(nameof(ActionType), value); }

        [Offset(72UL)]
        public uint StorageType { get => ReadHere<uint>(nameof(StorageType)); set => WriteHere(nameof(StorageType), value); }

        [Offset(80UL)]
        public IntPtr ParentUoW { get => ReadHere<IntPtr>(nameof(ParentUoW)); set => WriteHere(nameof(ParentUoW), value); }

        [Offset(88UL)]
        public IntPtr ChildKCB { get => ReadHere<IntPtr>(nameof(ChildKCB)); set => WriteHere(nameof(ChildKCB), value); }

        [Offset(88UL)]
        public uint VolatileKeyCell { get => ReadHere<uint>(nameof(VolatileKeyCell)); set => WriteHere(nameof(VolatileKeyCell), value); }

        [Offset(88UL)]
        public uint OldValueCell { get => ReadHere<uint>(nameof(OldValueCell)); set => WriteHere(nameof(OldValueCell), value); }

        [Offset(92UL)]
        public uint NewValueCell { get => ReadHere<uint>(nameof(NewValueCell)); set => WriteHere(nameof(NewValueCell), value); }

        [Offset(88UL)]
        public uint UserFlags { get => ReadHere<uint>(nameof(UserFlags)); set => WriteHere(nameof(UserFlags), value); }

        [Offset(88UL)]
        public LargeInteger LastWriteTime { get => ReadStructure<LargeInteger>(nameof(LastWriteTime)); set => WriteStructure(nameof(LastWriteTime), value); }

        [Offset(88UL)]
        public IntPtr TxCachedSecurity { get => ReadHere<IntPtr>(nameof(TxCachedSecurity)); set => WriteHere(nameof(TxCachedSecurity), value); }

        [Offset(96UL)]
        public uint TxSecurityCell { get => ReadHere<uint>(nameof(TxSecurityCell)); set => WriteHere(nameof(TxSecurityCell), value); }

        [Offset(100UL)]
        public byte UpdateEntireSecurity { get => ReadHere<byte>(nameof(UpdateEntireSecurity)); set => WriteHere(nameof(UpdateEntireSecurity), value); }

        [Offset(104UL)]
        public IntPtr PrepareDataPointer { get => ReadHere<IntPtr>(nameof(PrepareDataPointer)); set => WriteHere(nameof(PrepareDataPointer), value); }

        [Offset(104UL)]
        public IntPtr SecurityData { get => ReadHere<IntPtr>(nameof(SecurityData)); set => WriteHere(nameof(SecurityData), value); }

        [Offset(104UL)]
        public IntPtr ModifyKeysData { get => ReadHere<IntPtr>(nameof(ModifyKeysData)); set => WriteHere(nameof(ModifyKeysData), value); }

        [Offset(104UL)]
        public IntPtr SetValueData { get => ReadHere<IntPtr>(nameof(SetValueData)); set => WriteHere(nameof(SetValueData), value); }

        [Offset(112UL)]
        public IntPtr ValueData { get => ReadHere<IntPtr>(nameof(ValueData)); set => WriteHere(nameof(ValueData), value); }

        [Offset(112UL)]
        public IntPtr DiscardReplaceContext { get => ReadHere<IntPtr>(nameof(DiscardReplaceContext)); set => WriteHere(nameof(DiscardReplaceContext), value); }

        public CmKcbUow(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKcbUow>();
        }
    }
}