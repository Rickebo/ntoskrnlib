#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _SYSTEM_POWER_STATE_CONTEXT
    {
        [FieldOffset(0)]
        public uint Reserved1;
        [FieldOffset(0)]
        public uint TargetSystemState;
        [FieldOffset(0)]
        public uint EffectiveSystemState;
        [FieldOffset(0)]
        public uint CurrentSystemState;
        [FieldOffset(0)]
        public uint IgnoreHibernationPath;
        [FieldOffset(0)]
        public uint PseudoTransition;
        [FieldOffset(0)]
        public uint KernelSoftReboot;
        [FieldOffset(0)]
        public uint DirectedDripsTransition;
        [FieldOffset(0)]
        public uint Reserved2;
        [FieldOffset(0)]
        public uint ContextAsUlong;
    }
}