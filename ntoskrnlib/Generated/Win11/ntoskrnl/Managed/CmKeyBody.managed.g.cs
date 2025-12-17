using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CM_KEY_BODY")]
    public sealed class CmKeyBody : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public ushort AccessCheckedLayerHeight { get => ReadHere<ushort>(nameof(AccessCheckedLayerHeight)); set => WriteHere(nameof(AccessCheckedLayerHeight), value); }

        [Offset(8UL)]
        public IntPtr KeyControlBlock { get => ReadHere<IntPtr>(nameof(KeyControlBlock)); set => WriteHere(nameof(KeyControlBlock), value); }

        [Offset(16UL)]
        public IntPtr NotifyBlock { get => ReadHere<IntPtr>(nameof(NotifyBlock)); set => WriteHere(nameof(NotifyBlock), value); }

        [Offset(24UL)]
        public IntPtr ProcessID { get => ReadHere<IntPtr>(nameof(ProcessID)); set => WriteHere(nameof(ProcessID), value); }

        [Offset(32UL)]
        public ListEntry KeyBodyList { get => ReadStructure<ListEntry>(nameof(KeyBodyList)); set => WriteStructure(nameof(KeyBodyList), value); }

        [Offset(48UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(48UL)]
        public uint HandleTags { get => ReadHere<uint>(nameof(HandleTags)); set => WriteHere(nameof(HandleTags), value); }

        [Offset(56UL)]
        public CmTransPtr Trans { get => ReadStructure<CmTransPtr>(nameof(Trans)); set => WriteStructure(nameof(Trans), value); }

        [Offset(64UL)]
        public IntPtr KtmUow { get => ReadHere<IntPtr>(nameof(KtmUow)); set => WriteHere(nameof(KtmUow), value); }

        [Offset(72UL)]
        public ListEntry ContextListHead { get => ReadStructure<ListEntry>(nameof(ContextListHead)); set => WriteStructure(nameof(ContextListHead), value); }

        [Offset(88UL)]
        public IntPtr EnumerationResumeContext { get => ReadHere<IntPtr>(nameof(EnumerationResumeContext)); set => WriteHere(nameof(EnumerationResumeContext), value); }

        [Offset(96UL)]
        public uint RestrictedAccessMask { get => ReadHere<uint>(nameof(RestrictedAccessMask)); set => WriteHere(nameof(RestrictedAccessMask), value); }

        [Offset(100UL)]
        public uint LastSearchedIndex { get => ReadHere<uint>(nameof(LastSearchedIndex)); set => WriteHere(nameof(LastSearchedIndex), value); }

        [Offset(104UL)]
        public IntPtr LockedMemoryMdls { get => ReadHere<IntPtr>(nameof(LockedMemoryMdls)); set => WriteHere(nameof(LockedMemoryMdls), value); }

        public CmKeyBody(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmKeyBody>();
        }
    }
}