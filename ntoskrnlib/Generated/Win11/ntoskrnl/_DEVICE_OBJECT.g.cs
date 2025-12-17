#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 336)]
    public partial struct _DEVICE_OBJECT
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public ushort Size;
        [FieldOffset(4)]
        public int ReferenceCount;
        [FieldOffset(8)]
        public IntPtr DriverObject;
        [FieldOffset(16)]
        public IntPtr NextDevice;
        [FieldOffset(24)]
        public IntPtr AttachedDevice;
        [FieldOffset(32)]
        public IntPtr CurrentIrp;
        [FieldOffset(40)]
        public IntPtr Timer;
        [FieldOffset(48)]
        public uint Flags;
        [FieldOffset(52)]
        public uint Characteristics;
        [FieldOffset(56)]
        public IntPtr Vpb;
        [FieldOffset(64)]
        public IntPtr DeviceExtension;
        [FieldOffset(72)]
        public uint DeviceType;
        [FieldOffset(76)]
        public sbyte StackSize;
        [FieldOffset(80)]
        public _unnamed_tag_ Queue;
        [FieldOffset(152)]
        public uint AlignmentRequirement;
        [FieldOffset(160)]
        public _KDEVICE_QUEUE DeviceQueue;
        [FieldOffset(200)]
        public _KDPC Dpc;
        [FieldOffset(264)]
        public uint ActiveThreadCount;
        [FieldOffset(272)]
        public IntPtr SecurityDescriptor;
        [FieldOffset(280)]
        public _KEVENT DeviceLock;
        [FieldOffset(304)]
        public ushort SectorSize;
        [FieldOffset(306)]
        public ushort Spare1;
        [FieldOffset(312)]
        public IntPtr DeviceObjectExtension;
        [FieldOffset(320)]
        public IntPtr Reserved;
    }
}