using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_MAP")]
    public sealed class DeviceMap : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DosDevicesDirectory { get => ReadHere<IntPtr>(nameof(DosDevicesDirectory)); set => WriteHere(nameof(DosDevicesDirectory), value); }

        [Offset(8UL)]
        public IntPtr GlobalDosDevicesDirectory { get => ReadHere<IntPtr>(nameof(GlobalDosDevicesDirectory)); set => WriteHere(nameof(GlobalDosDevicesDirectory), value); }

        [Offset(16UL)]
        public IntPtr ServerSilo { get => ReadHere<IntPtr>(nameof(ServerSilo)); set => WriteHere(nameof(ServerSilo), value); }

        [Offset(24UL)]
        public IntPtr GlobalDeviceMap { get => ReadHere<IntPtr>(nameof(GlobalDeviceMap)); set => WriteHere(nameof(GlobalDeviceMap), value); }

        [Offset(32UL)]
        [Length(26)]
        public DynamicArray DriveObject { get => ReadStructure<DynamicArray>(nameof(DriveObject)); set => WriteStructure(nameof(DriveObject), value); }

        [Offset(240UL)]
        public long ReferenceCount { get => ReadHere<long>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(248UL)]
        public IntPtr DosDevicesDirectoryHandle { get => ReadHere<IntPtr>(nameof(DosDevicesDirectoryHandle)); set => WriteHere(nameof(DosDevicesDirectoryHandle), value); }

        [Offset(256UL)]
        public uint DriveMap { get => ReadHere<uint>(nameof(DriveMap)); set => WriteHere(nameof(DriveMap), value); }

        [Offset(260UL)]
        [Length(32)]
        public DynamicArray DriveType { get => ReadStructure<DynamicArray>(nameof(DriveType)); set => WriteStructure(nameof(DriveType), value); }

        public DeviceMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceMap>();
        }
    }
}