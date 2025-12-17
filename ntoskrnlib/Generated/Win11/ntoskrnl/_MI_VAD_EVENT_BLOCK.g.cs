#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _MI_VAD_EVENT_BLOCK
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public _KGATE Gate;
        [FieldOffset(8)]
        public _MMADDRESS_LIST SecureInfo;
        [FieldOffset(8)]
        public _MI_WRITE_WATCH_BLOCK WriteWatch;
        [FieldOffset(8)]
        public IntPtr InPageSupport;
        [FieldOffset(8)]
        public _MI_LARGEPAGE_VAD_INFO LargePage;
        [FieldOffset(8)]
        public _MI_PHYSICAL_VIEW AweView;
        [FieldOffset(8)]
        public IntPtr CreatingThread;
        [FieldOffset(8)]
        public _MI_SUB64K_FREE_RANGES PebTeb;
        [FieldOffset(8)]
        public IntPtr PlaceholderVad;
        [FieldOffset(8)]
        public IntPtr HotPatchEntry;
        [FieldOffset(80)]
        public uint WaitReason;
        [FieldOffset(84)]
        public uint CaseSpecificFlags;
    }
}