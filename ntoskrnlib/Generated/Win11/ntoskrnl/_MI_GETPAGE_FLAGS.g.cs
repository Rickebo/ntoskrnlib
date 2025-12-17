#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_GETPAGE_FLAGS
    {
        [FieldOffset(0)]
        public uint EntireField;
        [FieldOffset(0)]
        public uint AtDpc;
        [FieldOffset(0)]
        public uint PageLockHeld;
        [FieldOffset(0)]
        public uint RecursingToDemote;
        [FieldOffset(0)]
        public uint PageAttributeOptional;
        [FieldOffset(0)]
        public uint PreferZero;
        [FieldOffset(0)]
        public uint RequireZero;
        [FieldOffset(0)]
        public uint ColorAlignment;
        [FieldOffset(0)]
        public uint SystemUse;
        [FieldOffset(0)]
        public uint PreserveAvailable;
        [FieldOffset(0)]
        public uint IgnoreAvailable;
        [FieldOffset(0)]
        public uint ContendForListLocks;
        [FieldOffset(0)]
        public uint DontDemoteLargePages;
        [FieldOffset(0)]
        public uint NodeMandatory;
        [FieldOffset(0)]
        public uint ChannelMandatory;
        [FieldOffset(0)]
        public uint DontDemote;
        [FieldOffset(0)]
        public uint DontDemote64KPages;
        [FieldOffset(0)]
        public uint NoStandby;
        [FieldOffset(0)]
        public uint NoStandbySwap;
        [FieldOffset(0)]
        public uint OnlyStandby;
        [FieldOffset(0)]
        public uint FreeZeroQueryIncludeLarge;
        [FieldOffset(0)]
        public uint MustBeZero;
    }
}