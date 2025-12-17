#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 832)]
    public partial struct _MI_SYSTEM_NODE_INFORMATION
    {
        [FieldOffset(0)]
        public _MI_SYSTEM_NODE_AFFINITY_INFORMATION Affinities;
        [FieldOffset(32)]
        public _unnamed_tag_ Flags;
        [FieldOffset(44)]
        public _MI_NODE_NUMBER_ZERO_BASED ProcessorNode;
        [FieldOffset(48)]
        public _GROUP_AFFINITY ForwardProgressGroupAffinity;
        [FieldOffset(64)]
        public int LargePageListOpLock;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] WriteCalibration;
        [FieldOffset(576)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] MaximumBandwidth;
        [FieldOffset(640)]
        public int IoPfnLock;
        [FieldOffset(648)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _MI_DEFERRED_PFNS_TO_FREE[] DeferredPfnsToFree;
        [FieldOffset(776)]
        public _MI_DEFERRED_PFNS_TO_FREE DeferredPfnsReady;
        [FieldOffset(808)]
        public int DeferredPfnsToFreeLock;
    }
}