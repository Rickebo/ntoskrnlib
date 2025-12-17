using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETWP_NOTIFICATION_HEADER")]
    public sealed class EtwpNotificationHeader : DynamicStructure
    {
        [Offset(0UL)]
        public uint NotificationType { get => ReadHere<uint>(nameof(NotificationType)); set => WriteHere(nameof(NotificationType), value); }

        [Offset(4UL)]
        public uint NotificationSize { get => ReadHere<uint>(nameof(NotificationSize)); set => WriteHere(nameof(NotificationSize), value); }

        [Offset(8UL)]
        public int RefCount { get => ReadHere<int>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(12UL)]
        public byte ReplyRequested { get => ReadHere<byte>(nameof(ReplyRequested)); set => WriteHere(nameof(ReplyRequested), value); }

        [Offset(16UL)]
        public uint ReplyIndex { get => ReadHere<uint>(nameof(ReplyIndex)); set => WriteHere(nameof(ReplyIndex), value); }

        [Offset(16UL)]
        public uint Timeout { get => ReadHere<uint>(nameof(Timeout)); set => WriteHere(nameof(Timeout), value); }

        [Offset(20UL)]
        public uint ReplyCount { get => ReadHere<uint>(nameof(ReplyCount)); set => WriteHere(nameof(ReplyCount), value); }

        [Offset(20UL)]
        public uint NotifyeeCount { get => ReadHere<uint>(nameof(NotifyeeCount)); set => WriteHere(nameof(NotifyeeCount), value); }

        [Offset(24UL)]
        public ulong ReplyHandle { get => ReadHere<ulong>(nameof(ReplyHandle)); set => WriteHere(nameof(ReplyHandle), value); }

        [Offset(24UL)]
        public IntPtr ReplyObject { get => ReadHere<IntPtr>(nameof(ReplyObject)); set => WriteHere(nameof(ReplyObject), value); }

        [Offset(24UL)]
        public uint RegIndex { get => ReadHere<uint>(nameof(RegIndex)); set => WriteHere(nameof(RegIndex), value); }

        [Offset(32UL)]
        public uint TargetPID { get => ReadHere<uint>(nameof(TargetPID)); set => WriteHere(nameof(TargetPID), value); }

        [Offset(36UL)]
        public uint SourcePID { get => ReadHere<uint>(nameof(SourcePID)); set => WriteHere(nameof(SourcePID), value); }

        [Offset(40UL)]
        public Guid DestinationGuid { get => ReadStructure<Guid>(nameof(DestinationGuid)); set => WriteStructure(nameof(DestinationGuid), value); }

        [Offset(56UL)]
        public Guid SourceGuid { get => ReadStructure<Guid>(nameof(SourceGuid)); set => WriteStructure(nameof(SourceGuid), value); }

        public EtwpNotificationHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwpNotificationHeader>();
        }
    }
}