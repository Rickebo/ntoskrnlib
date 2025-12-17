using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DRIVER_OBJECT")]
    public sealed class DriverObject : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(16UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(24UL)]
        public IntPtr DriverStart { get => ReadHere<IntPtr>(nameof(DriverStart)); set => WriteHere(nameof(DriverStart), value); }

        [Offset(32UL)]
        public uint DriverSize { get => ReadHere<uint>(nameof(DriverSize)); set => WriteHere(nameof(DriverSize), value); }

        [Offset(40UL)]
        public IntPtr DriverSection { get => ReadHere<IntPtr>(nameof(DriverSection)); set => WriteHere(nameof(DriverSection), value); }

        [Offset(48UL)]
        public IntPtr DriverExtension { get => ReadHere<IntPtr>(nameof(DriverExtension)); set => WriteHere(nameof(DriverExtension), value); }

        [Offset(56UL)]
        public UnicodeString DriverName { get => ReadStructure<UnicodeString>(nameof(DriverName)); set => WriteStructure(nameof(DriverName), value); }

        [Offset(72UL)]
        public IntPtr HardwareDatabase { get => ReadHere<IntPtr>(nameof(HardwareDatabase)); set => WriteHere(nameof(HardwareDatabase), value); }

        [Offset(80UL)]
        public IntPtr FastIoDispatch { get => ReadHere<IntPtr>(nameof(FastIoDispatch)); set => WriteHere(nameof(FastIoDispatch), value); }

        [Offset(88UL)]
        public IntPtr DriverInit { get => ReadHere<IntPtr>(nameof(DriverInit)); set => WriteHere(nameof(DriverInit), value); }

        [Offset(96UL)]
        public IntPtr DriverStartIo { get => ReadHere<IntPtr>(nameof(DriverStartIo)); set => WriteHere(nameof(DriverStartIo), value); }

        [Offset(104UL)]
        public IntPtr DriverUnload { get => ReadHere<IntPtr>(nameof(DriverUnload)); set => WriteHere(nameof(DriverUnload), value); }

        [Offset(112UL)]
        [Length(28)]
        public DynamicArray MajorFunction { get => ReadStructure<DynamicArray>(nameof(MajorFunction)); set => WriteStructure(nameof(MajorFunction), value); }

        public DriverObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DriverObject>();
        }
    }
}