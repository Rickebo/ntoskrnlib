using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KENLISTMENT")]
    public sealed class Kenlistment : DynamicStructure
    {
        [Offset(0UL)]
        public uint cookie { get => ReadHere<uint>(nameof(cookie)); set => WriteHere(nameof(cookie), value); }

        [Offset(8UL)]
        public KtmobjectNamespaceLink NamespaceLink { get => ReadStructure<KtmobjectNamespaceLink>(nameof(NamespaceLink)); set => WriteStructure(nameof(NamespaceLink), value); }

        [Offset(48UL)]
        public Guid EnlistmentId { get => ReadStructure<Guid>(nameof(EnlistmentId)); set => WriteStructure(nameof(EnlistmentId), value); }

        [Offset(64UL)]
        public Kmutant Mutex { get => ReadStructure<Kmutant>(nameof(Mutex)); set => WriteStructure(nameof(Mutex), value); }

        [Offset(120UL)]
        public ListEntry NextSameTx { get => ReadStructure<ListEntry>(nameof(NextSameTx)); set => WriteStructure(nameof(NextSameTx), value); }

        [Offset(136UL)]
        public ListEntry NextSameRm { get => ReadStructure<ListEntry>(nameof(NextSameRm)); set => WriteStructure(nameof(NextSameRm), value); }

        [Offset(152UL)]
        public IntPtr ResourceManager { get => ReadHere<IntPtr>(nameof(ResourceManager)); set => WriteHere(nameof(ResourceManager), value); }

        [Offset(160UL)]
        public IntPtr Transaction { get => ReadHere<IntPtr>(nameof(Transaction)); set => WriteHere(nameof(Transaction), value); }

        [Offset(168UL)]
        public uint State { get => ReadHere<uint>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(172UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(176UL)]
        public uint NotificationMask { get => ReadHere<uint>(nameof(NotificationMask)); set => WriteHere(nameof(NotificationMask), value); }

        [Offset(184UL)]
        public IntPtr Key { get => ReadHere<IntPtr>(nameof(Key)); set => WriteHere(nameof(Key), value); }

        [Offset(192UL)]
        public uint KeyRefCount { get => ReadHere<uint>(nameof(KeyRefCount)); set => WriteHere(nameof(KeyRefCount), value); }

        [Offset(200UL)]
        public IntPtr RecoveryInformation { get => ReadHere<IntPtr>(nameof(RecoveryInformation)); set => WriteHere(nameof(RecoveryInformation), value); }

        [Offset(208UL)]
        public uint RecoveryInformationLength { get => ReadHere<uint>(nameof(RecoveryInformationLength)); set => WriteHere(nameof(RecoveryInformationLength), value); }

        [Offset(216UL)]
        public IntPtr DynamicNameInformation { get => ReadHere<IntPtr>(nameof(DynamicNameInformation)); set => WriteHere(nameof(DynamicNameInformation), value); }

        [Offset(224UL)]
        public uint DynamicNameInformationLength { get => ReadHere<uint>(nameof(DynamicNameInformationLength)); set => WriteHere(nameof(DynamicNameInformationLength), value); }

        [Offset(232UL)]
        public IntPtr FinalNotification { get => ReadHere<IntPtr>(nameof(FinalNotification)); set => WriteHere(nameof(FinalNotification), value); }

        [Offset(240UL)]
        public IntPtr SupSubEnlistment { get => ReadHere<IntPtr>(nameof(SupSubEnlistment)); set => WriteHere(nameof(SupSubEnlistment), value); }

        [Offset(248UL)]
        public IntPtr SupSubEnlHandle { get => ReadHere<IntPtr>(nameof(SupSubEnlHandle)); set => WriteHere(nameof(SupSubEnlHandle), value); }

        [Offset(256UL)]
        public IntPtr SubordinateTxHandle { get => ReadHere<IntPtr>(nameof(SubordinateTxHandle)); set => WriteHere(nameof(SubordinateTxHandle), value); }

        [Offset(264UL)]
        public Guid CrmEnlistmentEnId { get => ReadStructure<Guid>(nameof(CrmEnlistmentEnId)); set => WriteStructure(nameof(CrmEnlistmentEnId), value); }

        [Offset(280UL)]
        public Guid CrmEnlistmentTmId { get => ReadStructure<Guid>(nameof(CrmEnlistmentTmId)); set => WriteStructure(nameof(CrmEnlistmentTmId), value); }

        [Offset(296UL)]
        public Guid CrmEnlistmentRmId { get => ReadStructure<Guid>(nameof(CrmEnlistmentRmId)); set => WriteStructure(nameof(CrmEnlistmentRmId), value); }

        [Offset(312UL)]
        public uint NextHistory { get => ReadHere<uint>(nameof(NextHistory)); set => WriteHere(nameof(NextHistory), value); }

        [Offset(316UL)]
        [Length(20)]
        public DynamicArray History { get => ReadStructure<DynamicArray>(nameof(History)); set => WriteStructure(nameof(History), value); }

        public Kenlistment(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kenlistment>();
        }
    }
}