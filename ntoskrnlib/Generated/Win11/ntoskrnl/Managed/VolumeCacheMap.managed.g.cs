using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VOLUME_CACHE_MAP")]
    public sealed class VolumeCacheMap : DynamicStructure
    {
        [Offset(0UL)]
        public short NodeTypeCode { get => ReadHere<short>(nameof(NodeTypeCode)); set => WriteHere(nameof(NodeTypeCode), value); }

        [Offset(2UL)]
        public short NodeByteCode { get => ReadHere<short>(nameof(NodeByteCode)); set => WriteHere(nameof(NodeByteCode), value); }

        [Offset(8UL)]
        public long UseCount { get => ReadHere<long>(nameof(UseCount)); set => WriteHere(nameof(UseCount), value); }

        [Offset(16UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(24UL)]
        public ListEntry VolumeCacheMapLinks { get => ReadStructure<ListEntry>(nameof(VolumeCacheMapLinks)); set => WriteStructure(nameof(VolumeCacheMapLinks), value); }

        [Offset(40UL)]
        public ulong DirtyPages { get => ReadHere<ulong>(nameof(DirtyPages)); set => WriteHere(nameof(DirtyPages), value); }

        [Offset(48UL)]
        public LogHandleContext LogHandleContext { get => ReadStructure<LogHandleContext>(nameof(LogHandleContext)); set => WriteStructure(nameof(LogHandleContext), value); }

        [Offset(200UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(204UL)]
        public uint PagesQueuedToDisk { get => ReadHere<uint>(nameof(PagesQueuedToDisk)); set => WriteHere(nameof(PagesQueuedToDisk), value); }

        [Offset(208UL)]
        public uint LoggedPagesQueuedToDisk { get => ReadHere<uint>(nameof(LoggedPagesQueuedToDisk)); set => WriteHere(nameof(LoggedPagesQueuedToDisk), value); }

        [Offset(212UL)]
        public uint VolumeId { get => ReadHere<uint>(nameof(VolumeId)); set => WriteHere(nameof(VolumeId), value); }

        [Offset(216UL)]
        public ListEntry PrivateVolumeList { get => ReadStructure<ListEntry>(nameof(PrivateVolumeList)); set => WriteStructure(nameof(PrivateVolumeList), value); }

        [Offset(232UL)]
        public CcVolumeTelemetry VolumeTelemetry { get => ReadStructure<CcVolumeTelemetry>(nameof(VolumeTelemetry)); set => WriteStructure(nameof(VolumeTelemetry), value); }

        [Offset(2712UL)]
        public KeRcuWorkitem RcuContext { get => ReadStructure<KeRcuWorkitem>(nameof(RcuContext)); set => WriteStructure(nameof(RcuContext), value); }

        public VolumeCacheMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VolumeCacheMap>();
        }
    }
}