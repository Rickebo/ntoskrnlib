#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _VIRTUAL_EFI_RUNTIME_SERVICES
    {
        [FieldOffset(0)]
        public ulong GetTime;
        [FieldOffset(8)]
        public ulong SetTime;
        [FieldOffset(16)]
        public ulong GetWakeupTime;
        [FieldOffset(24)]
        public ulong SetWakeupTime;
        [FieldOffset(32)]
        public ulong SetVirtualAddressMap;
        [FieldOffset(40)]
        public ulong ConvertPointer;
        [FieldOffset(48)]
        public ulong GetVariable;
        [FieldOffset(56)]
        public ulong GetNextVariableName;
        [FieldOffset(64)]
        public ulong SetVariable;
        [FieldOffset(72)]
        public ulong GetNextHighMonotonicCount;
        [FieldOffset(80)]
        public ulong ResetSystem;
        [FieldOffset(88)]
        public ulong UpdateCapsule;
        [FieldOffset(96)]
        public ulong QueryCapsuleCapabilities;
        [FieldOffset(104)]
        public ulong QueryVariableInfo;
    }
}