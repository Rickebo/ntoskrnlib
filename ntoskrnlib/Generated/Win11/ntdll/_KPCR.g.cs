#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 53376)]
    public partial struct _KPCR
    {
        [FieldOffset(0)]
        public _NT_TIB NtTib;
        [FieldOffset(0)]
        public IntPtr GdtBase;
        [FieldOffset(8)]
        public IntPtr TssBase;
        [FieldOffset(16)]
        public ulong UserRsp;
        [FieldOffset(24)]
        public IntPtr Self;
        [FieldOffset(32)]
        public IntPtr CurrentPrcb;
        [FieldOffset(40)]
        public IntPtr LockArray;
        [FieldOffset(48)]
        public IntPtr Used_Self;
        [FieldOffset(56)]
        public IntPtr IdtBase;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] Unused;
        [FieldOffset(80)]
        public byte Irql;
        [FieldOffset(81)]
        public byte SecondLevelCacheAssociativity;
        [FieldOffset(82)]
        public byte ObsoleteNumber;
        [FieldOffset(83)]
        public byte Fill0;
        [FieldOffset(84)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] Unused0;
        [FieldOffset(96)]
        public ushort MajorVersion;
        [FieldOffset(98)]
        public ushort MinorVersion;
        [FieldOffset(100)]
        public uint StallScaleFactor;
        [FieldOffset(104)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public IntPtr[] Unused1;
        [FieldOffset(128)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public uint[] KernelReserved;
        [FieldOffset(188)]
        public uint SecondLevelCacheSize;
        [FieldOffset(192)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] HalReserved;
        [FieldOffset(256)]
        public uint Unused2;
        [FieldOffset(264)]
        public IntPtr KdVersionBlock;
        [FieldOffset(272)]
        public IntPtr Unused3;
        [FieldOffset(280)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public uint[] PcrAlign1;
        [FieldOffset(384)]
        public _KPRCB Prcb;
    }
}