using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_TARGET_ALL_SHARED_EXPORT_THUNKS")]
    public sealed class VfTargetAllSharedExportThunks : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SharedExportThunks { get => ReadHere<IntPtr>(nameof(SharedExportThunks)); set => WriteHere(nameof(SharedExportThunks), value); }

        [Offset(8UL)]
        public IntPtr PoolSharedExportThunks { get => ReadHere<IntPtr>(nameof(PoolSharedExportThunks)); set => WriteHere(nameof(PoolSharedExportThunks), value); }

        [Offset(16UL)]
        public IntPtr XdvSharedExportThunks { get => ReadHere<IntPtr>(nameof(XdvSharedExportThunks)); set => WriteHere(nameof(XdvSharedExportThunks), value); }

        public VfTargetAllSharedExportThunks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfTargetAllSharedExportThunks>();
        }
    }
}