using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CMP_VOLUME_CONTEXT")]
    public sealed class CmpVolumeContext : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry VolumeContextListEntry { get => ReadStructure<ListEntry>(nameof(VolumeContextListEntry)); set => WriteStructure(nameof(VolumeContextListEntry), value); }

        [Offset(16UL)]
        public IntPtr VolumeManager { get => ReadHere<IntPtr>(nameof(VolumeManager)); set => WriteHere(nameof(VolumeManager), value); }

        [Offset(24UL)]
        public long RefCount { get => ReadHere<long>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(32UL)]
        public Guid VolumeGuid { get => ReadStructure<Guid>(nameof(VolumeGuid)); set => WriteStructure(nameof(VolumeGuid), value); }

        [Offset(48UL)]
        public IntPtr VolumeFileObject { get => ReadHere<IntPtr>(nameof(VolumeFileObject)); set => WriteHere(nameof(VolumeFileObject), value); }

        [Offset(56UL)]
        public CmsiRwLock VolumeContextLock { get => ReadStructure<CmsiRwLock>(nameof(VolumeContextLock)); set => WriteStructure(nameof(VolumeContextLock), value); }

        [Offset(64UL)]
        public uint DeviceUsageNotificationState { get => ReadHere<uint>(nameof(DeviceUsageNotificationState)); set => WriteHere(nameof(DeviceUsageNotificationState), value); }

        public CmpVolumeContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmpVolumeContext>();
        }
    }
}