using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_BUS_INTERFACE")]
    public sealed class IommuBusInterface : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(2UL)]
        public ushort Version { get => ReadHere<ushort>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(16UL)]
        public IntPtr InterfaceReference { get => ReadHere<IntPtr>(nameof(InterfaceReference)); set => WriteHere(nameof(InterfaceReference), value); }

        [Offset(24UL)]
        public IntPtr InterfaceDereference { get => ReadHere<IntPtr>(nameof(InterfaceDereference)); set => WriteHere(nameof(InterfaceDereference), value); }

        [Offset(32UL)]
        public IntPtr GetSvmCapabilities { get => ReadHere<IntPtr>(nameof(GetSvmCapabilities)); set => WriteHere(nameof(GetSvmCapabilities), value); }

        [Offset(40UL)]
        public IntPtr EnableSvmCapabilities { get => ReadHere<IntPtr>(nameof(EnableSvmCapabilities)); set => WriteHere(nameof(EnableSvmCapabilities), value); }

        [Offset(48UL)]
        public IntPtr DisableSvmCapabilities { get => ReadHere<IntPtr>(nameof(DisableSvmCapabilities)); set => WriteHere(nameof(DisableSvmCapabilities), value); }

        [Offset(56UL)]
        public IntPtr GetDeviceProperties { get => ReadHere<IntPtr>(nameof(GetDeviceProperties)); set => WriteHere(nameof(GetDeviceProperties), value); }

        [Offset(64UL)]
        public IntPtr GetDeviceId { get => ReadHere<IntPtr>(nameof(GetDeviceId)); set => WriteHere(nameof(GetDeviceId), value); }

        [Offset(72UL)]
        public IntPtr GetRootDevice { get => ReadHere<IntPtr>(nameof(GetRootDevice)); set => WriteHere(nameof(GetRootDevice), value); }

        public IommuBusInterface(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuBusInterface>();
        }
    }
}