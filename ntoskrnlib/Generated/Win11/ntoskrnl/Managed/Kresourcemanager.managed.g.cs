using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KRESOURCEMANAGER")]
    public sealed class Kresourcemanager : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent NotificationAvailable { get => ReadStructure<Kevent>(nameof(NotificationAvailable)); set => WriteStructure(nameof(NotificationAvailable), value); }

        [Offset(24UL)]
        public uint cookie { get => ReadHere<uint>(nameof(cookie)); set => WriteHere(nameof(cookie), value); }

        [Offset(28UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(32UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(40UL)]
        public Kmutant Mutex { get => ReadStructure<Kmutant>(nameof(Mutex)); set => WriteStructure(nameof(Mutex), value); }

        [Offset(96UL)]
        public KtmobjectNamespaceLink NamespaceLink { get => ReadStructure<KtmobjectNamespaceLink>(nameof(NamespaceLink)); set => WriteStructure(nameof(NamespaceLink), value); }

        [Offset(136UL)]
        public Guid RmId { get => ReadStructure<Guid>(nameof(RmId)); set => WriteStructure(nameof(RmId), value); }

        [Offset(152UL)]
        public Kqueue NotificationQueue { get => ReadStructure<Kqueue>(nameof(NotificationQueue)); set => WriteStructure(nameof(NotificationQueue), value); }

        [Offset(216UL)]
        public Kmutant NotificationMutex { get => ReadStructure<Kmutant>(nameof(NotificationMutex)); set => WriteStructure(nameof(NotificationMutex), value); }

        [Offset(272UL)]
        public ListEntry EnlistmentHead { get => ReadStructure<ListEntry>(nameof(EnlistmentHead)); set => WriteStructure(nameof(EnlistmentHead), value); }

        [Offset(288UL)]
        public uint EnlistmentCount { get => ReadHere<uint>(nameof(EnlistmentCount)); set => WriteHere(nameof(EnlistmentCount), value); }

        [Offset(296UL)]
        public IntPtr NotificationRoutine { get => ReadHere<IntPtr>(nameof(NotificationRoutine)); set => WriteHere(nameof(NotificationRoutine), value); }

        [Offset(304UL)]
        public IntPtr Key { get => ReadHere<IntPtr>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(312UL)]
        public ListEntry ProtocolListHead { get => ReadStructure<ListEntry>(nameof(ProtocolListHead)); set => WriteStructure(nameof(ProtocolListHead), value); }

        [Offset(328UL)]
        public ListEntry PendingPropReqListHead { get => ReadStructure<ListEntry>(nameof(PendingPropReqListHead)); set => WriteStructure(nameof(PendingPropReqListHead), value); }

        [Offset(344UL)]
        public ListEntry CRMListEntry { get => ReadStructure<ListEntry>(nameof(CRMListEntry)); set => WriteStructure(nameof(CRMListEntry), value); }

        [Offset(360UL)]
        public IntPtr Tm { get => ReadHere<IntPtr>(nameof(Tm)); set => WriteHere(nameof(Tm), value); }

        [Offset(368UL)]
        public UnicodeString Description { get => ReadStructure<UnicodeString>(nameof(Description)); set => WriteStructure(nameof(Description), value); }

        [Offset(384UL)]
        public KtmobjectNamespace Enlistments { get => ReadStructure<KtmobjectNamespace>(nameof(Enlistments)); set => WriteStructure(nameof(Enlistments), value); }

        [Offset(552UL)]
        public KresourcemanagerCompletionBinding CompletionBinding { get => ReadStructure<KresourcemanagerCompletionBinding>(nameof(CompletionBinding)); set => WriteStructure(nameof(CompletionBinding), value); }

        public Kresourcemanager(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kresourcemanager>();
        }
    }
}