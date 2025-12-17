#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 840)]
    public partial struct _XSTATE_CONFIGURATION
    {
        [FieldOffset(0)]
        public ulong EnabledFeatures;
        [FieldOffset(8)]
        public ulong EnabledVolatileFeatures;
        [FieldOffset(16)]
        public uint Size;
        [FieldOffset(20)]
        public uint ControlFlags;
        [FieldOffset(20)]
        public uint OptimizedSave;
        [FieldOffset(20)]
        public uint CompactionEnabled;
        [FieldOffset(20)]
        public uint ExtendedFeatureDisable;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _XSTATE_FEATURE[] Features;
        [FieldOffset(536)]
        public ulong EnabledSupervisorFeatures;
        [FieldOffset(544)]
        public ulong AlignedFeatures;
        [FieldOffset(552)]
        public uint AllFeatureSize;
        [FieldOffset(556)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] AllFeatures;
        [FieldOffset(816)]
        public ulong EnabledUserVisibleSupervisorFeatures;
        [FieldOffset(824)]
        public ulong ExtendedFeatureDisableFeatures;
        [FieldOffset(832)]
        public uint AllNonLargeFeatureSize;
        [FieldOffset(836)]
        public ushort MaxSveVectorLength;
        [FieldOffset(838)]
        public ushort Spare1;
    }
}