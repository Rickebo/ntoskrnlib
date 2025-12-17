#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 352)]
    public partial struct _MI_STANDBY_STATE
    {
        [FieldOffset(0)]
        public ulong FirstDecayPage;
        [FieldOffset(16)]
        public _SLIST_HEADER PfnDecayFreeSList;
        [FieldOffset(32)]
        public int DecayPfnLock;
        [FieldOffset(40)]
        public _RTL_BITMAP DecayPfnsToBeFreed;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] DecayPfnsToBeFreedBuffer;
        [FieldOffset(320)]
        public _SLIST_HEADER PageHeatListSlist;
        [FieldOffset(336)]
        public int PageHeatListDisableAllocation;
        [FieldOffset(340)]
        public uint TransitionPagesMadeCold;
    }
}