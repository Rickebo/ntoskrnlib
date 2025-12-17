#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _PROCESS_ENERGY_VALUES_EXTENSION
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public _TIMELINE_BITMAP[] Timelines;
        [FieldOffset(0)]
        public _TIMELINE_BITMAP CpuTimeline;
        [FieldOffset(8)]
        public _TIMELINE_BITMAP DiskTimeline;
        [FieldOffset(16)]
        public _TIMELINE_BITMAP NetworkTimeline;
        [FieldOffset(24)]
        public _TIMELINE_BITMAP MBBTimeline;
        [FieldOffset(32)]
        public _TIMELINE_BITMAP ForegroundTimeline;
        [FieldOffset(40)]
        public _TIMELINE_BITMAP DesktopVisibleTimeline;
        [FieldOffset(48)]
        public _TIMELINE_BITMAP CompositionRenderedTimeline;
        [FieldOffset(56)]
        public _TIMELINE_BITMAP CompositionDirtyGeneratedTimeline;
        [FieldOffset(64)]
        public _TIMELINE_BITMAP CompositionDirtyPropagatedTimeline;
        [FieldOffset(72)]
        public _TIMELINE_BITMAP InputTimeline;
        [FieldOffset(80)]
        public _TIMELINE_BITMAP AudioInTimeline;
        [FieldOffset(88)]
        public _TIMELINE_BITMAP AudioOutTimeline;
        [FieldOffset(96)]
        public _TIMELINE_BITMAP DisplayRequiredTimeline;
        [FieldOffset(104)]
        public _TIMELINE_BITMAP KeyboardInputTimeline;
        [FieldOffset(112)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public _ENERGY_STATE_DURATION[] Durations;
        [FieldOffset(112)]
        public _ENERGY_STATE_DURATION InputDuration;
        [FieldOffset(120)]
        public _ENERGY_STATE_DURATION AudioInDuration;
        [FieldOffset(128)]
        public _ENERGY_STATE_DURATION AudioOutDuration;
        [FieldOffset(136)]
        public _ENERGY_STATE_DURATION DisplayRequiredDuration;
        [FieldOffset(144)]
        public _ENERGY_STATE_DURATION PSMBackgroundDuration;
        [FieldOffset(152)]
        public uint KeyboardInput;
        [FieldOffset(156)]
        public uint MouseInput;
    }
}