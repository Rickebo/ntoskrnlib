#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _MI_PROCESS_STATE
    {
        [FieldOffset(0)]
        public IntPtr SystemDllBase;
        [FieldOffset(8)]
        public uint ColorSeed;
        [FieldOffset(12)]
        public int RotatingUniprocessorNumber;
        [FieldOffset(16)]
        public _LARGE_INTEGER CriticalSectionTimeout;
        [FieldOffset(24)]
        public _LIST_ENTRY ProcessList;
        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public IntPtr[] SharedUserDataPte;
        [FieldOffset(56)]
        public IntPtr HypervisorSharedVa;
        [FieldOffset(64)]
        public ulong VadSecureCookie;
        [FieldOffset(72)]
        public IntPtr NativeCfgBitmapPreferredAddress;
        [FieldOffset(80)]
        public IntPtr EcBitmapPreferredAddress;
    }
}