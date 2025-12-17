#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20480)]
    public partial struct _KPROCESSOR_DESCRIPTOR_AREA
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public _KIDTENTRY64[] Idt;
        [FieldOffset(4096)]
        public _KTSS64 Tss;
        [FieldOffset(4200)]
        public ulong TssSpare;
        [FieldOffset(4208)]
        public IntPtr KernelGsBase;
        [FieldOffset(4216)]
        public IntPtr IdleStack;
        [FieldOffset(4224)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3888)]
        public byte[] TssPad;
        [FieldOffset(8112)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)]
        public byte[] GdtPadTemp;
        [FieldOffset(12208)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public _KGDTENTRY64[] Gdt;
        [FieldOffset(12288)]
        public _KLDTENTRY GdtCmTebDescriptor;
        [FieldOffset(12296)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4088)]
        public byte[] GdtEndPadding;
        [FieldOffset(16384)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _KTRANSITION_STACK[] TransitionStack;
    }
}