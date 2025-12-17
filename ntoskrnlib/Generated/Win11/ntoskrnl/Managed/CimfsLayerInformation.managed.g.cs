using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CIMFS_LAYER_INFORMATION")]
    public sealed class CimfsLayerInformation : DynamicStructure
    {
        [Offset(0UL)]
        public Guid TargetVolume { get => ReadStructure<Guid>(nameof(TargetVolume)); set => WriteStructure(nameof(TargetVolume), value); }

        [Offset(16UL)]
        public IntPtr CimFiles { get => ReadHere<IntPtr>(nameof(CimFiles)); set => WriteHere(nameof(CimFiles), value); }

        [Offset(24UL)]
        public uint CimFilesCount { get => ReadHere<uint>(nameof(CimFilesCount)); set => WriteHere(nameof(CimFilesCount), value); }

        [Offset(28UL)]
        public uint MountFlags { get => ReadHere<uint>(nameof(MountFlags)); set => WriteHere(nameof(MountFlags), value); }

        [Offset(32UL)]
        public byte ParentIsVsmb { get => ReadHere<byte>(nameof(ParentIsVsmb)); set => WriteHere(nameof(ParentIsVsmb), value); }

        [Offset(40UL)]
        public IntPtr ParentDeviceArcName { get => ReadHere<IntPtr>(nameof(ParentDeviceArcName)); set => WriteHere(nameof(ParentDeviceArcName), value); }

        public CimfsLayerInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CimfsLayerInformation>();
        }
    }
}