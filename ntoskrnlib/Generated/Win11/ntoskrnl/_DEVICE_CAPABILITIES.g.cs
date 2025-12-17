#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _DEVICE_CAPABILITIES
    {
        [FieldOffset(0)]
        public ushort Size;
        [FieldOffset(2)]
        public ushort Version;
        [FieldOffset(4)]
        public uint DeviceD1;
        [FieldOffset(4)]
        public uint DeviceD2;
        [FieldOffset(4)]
        public uint LockSupported;
        [FieldOffset(4)]
        public uint EjectSupported;
        [FieldOffset(4)]
        public uint Removable;
        [FieldOffset(4)]
        public uint DockDevice;
        [FieldOffset(4)]
        public uint UniqueID;
        [FieldOffset(4)]
        public uint SilentInstall;
        [FieldOffset(4)]
        public uint RawDeviceOK;
        [FieldOffset(4)]
        public uint SurpriseRemovalOK;
        [FieldOffset(4)]
        public uint WakeFromD0;
        [FieldOffset(4)]
        public uint WakeFromD1;
        [FieldOffset(4)]
        public uint WakeFromD2;
        [FieldOffset(4)]
        public uint WakeFromD3;
        [FieldOffset(4)]
        public uint HardwareDisabled;
        [FieldOffset(4)]
        public uint NonDynamic;
        [FieldOffset(4)]
        public uint WarmEjectSupported;
        [FieldOffset(4)]
        public uint NoDisplayInUI;
        [FieldOffset(4)]
        public uint Reserved1;
        [FieldOffset(4)]
        public uint WakeFromInterrupt;
        [FieldOffset(4)]
        public uint SecureDevice;
        [FieldOffset(4)]
        public uint ChildOfVgaEnabledBridge;
        [FieldOffset(4)]
        public uint DecodeIoOnBoot;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(8)]
        public uint Address;
        [FieldOffset(12)]
        public uint UINumber;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public uint[] DeviceState;
        [FieldOffset(44)]
        public uint SystemWake;
        [FieldOffset(48)]
        public uint DeviceWake;
        [FieldOffset(52)]
        public uint D1Latency;
        [FieldOffset(56)]
        public uint D2Latency;
        [FieldOffset(60)]
        public uint D3Latency;
    }
}