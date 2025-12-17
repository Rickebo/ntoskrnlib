using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CMP_VOLUME_MANAGER")]
    public sealed class CmpVolumeManager : DynamicStructure
    {
        [Offset(0UL)]
        public CmsiRwLock VolumeContextListLock { get => ReadStructure<CmsiRwLock>(nameof(VolumeContextListLock)); set => WriteStructure(nameof(VolumeContextListLock), value); }

        [Offset(8UL)]
        public ListEntry VolumeContextListHead { get => ReadStructure<ListEntry>(nameof(VolumeContextListHead)); set => WriteStructure(nameof(VolumeContextListHead), value); }

        public CmpVolumeManager(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmpVolumeManager>();
        }
    }
}