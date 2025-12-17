using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_OBJECT")]
    public sealed class DeviceObject : DynamicStructure
    {
        [Offset(0UL)]
        public short Type { get => ReadHere<short>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public int ReferenceCount { get => ReadHere<int>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(8UL)]
        public IntPtr DriverObject { get => ReadHere<IntPtr>(nameof(DriverObject)); set => WriteHere(nameof(DriverObject), value); }

        [Offset(16UL)]
        public IntPtr NextDevice { get => ReadHere<IntPtr>(nameof(NextDevice)); set => WriteHere(nameof(NextDevice), value); }

        [Offset(24UL)]
        public IntPtr AttachedDevice { get => ReadHere<IntPtr>(nameof(AttachedDevice)); set => WriteHere(nameof(AttachedDevice), value); }

        [Offset(32UL)]
        public IntPtr CurrentIrp { get => ReadHere<IntPtr>(nameof(CurrentIrp)); set => WriteHere(nameof(CurrentIrp), value); }

        [Offset(40UL)]
        public IntPtr Timer { get => ReadHere<IntPtr>(nameof(Timer)); set => WriteHere(nameof(Timer), value); }

        [Offset(48UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(52UL)]
        public uint Characteristics { get => ReadHere<uint>(nameof(Characteristics)); set => WriteHere(nameof(Characteristics), value); }

        [Offset(56UL)]
        public IntPtr Vpb { get => ReadHere<IntPtr>(nameof(Vpb)); set => WriteHere(nameof(Vpb), value); }

        [Offset(64UL)]
        public IntPtr DeviceExtension { get => ReadHere<IntPtr>(nameof(DeviceExtension)); set => WriteHere(nameof(DeviceExtension), value); }

        [Offset(72UL)]
        public uint DeviceType { get => ReadHere<uint>(nameof(DeviceType)); set => WriteHere(nameof(DeviceType), value); }

        [Offset(76UL)]
        public sbyte StackSize { get => ReadHere<sbyte>(nameof(StackSize)); set => WriteHere(nameof(StackSize), value); }

        [Offset(80UL)]
        public UnnamedTag Queue { get => ReadStructure<UnnamedTag>(nameof(Queue)); set => WriteStructure(nameof(Queue), value); }

        [Offset(152UL)]
        public uint AlignmentRequirement { get => ReadHere<uint>(nameof(AlignmentRequirement)); set => WriteHere(nameof(AlignmentRequirement), value); }

        [Offset(160UL)]
        public KdeviceQueue DeviceQueue { get => ReadStructure<KdeviceQueue>(nameof(DeviceQueue)); set => WriteStructure(nameof(DeviceQueue), value); }

        [Offset(200UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(264UL)]
        public uint ActiveThreadCount { get => ReadHere<uint>(nameof(ActiveThreadCount)); set => WriteHere(nameof(ActiveThreadCount), value); }

        [Offset(272UL)]
        public IntPtr SecurityDescriptor { get => ReadHere<IntPtr>(nameof(SecurityDescriptor)); set => WriteHere(nameof(SecurityDescriptor), value); }

        [Offset(280UL)]
        public Kevent DeviceLock { get => ReadStructure<Kevent>(nameof(DeviceLock)); set => WriteStructure(nameof(DeviceLock), value); }

        [Offset(304UL)]
        public ushort SectorSize { get => ReadHere<ushort>(nameof(SectorSize)); set => WriteHere(nameof(SectorSize), value); }

        [Offset(306UL)]
        public ushort Spare1 { get => ReadHere<ushort>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(312UL)]
        public IntPtr DeviceObjectExtension { get => ReadHere<IntPtr>(nameof(DeviceObjectExtension)); set => WriteHere(nameof(DeviceObjectExtension), value); }

        [Offset(320UL)]
        public IntPtr Reserved { get => ReadHere<IntPtr>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public DeviceObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceObject>();
        }
    }
}