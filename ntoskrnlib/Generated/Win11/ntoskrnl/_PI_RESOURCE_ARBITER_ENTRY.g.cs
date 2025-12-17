#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _PI_RESOURCE_ARBITER_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY DeviceArbiterList;
        [FieldOffset(16)]
        public byte ResourceType;
        [FieldOffset(24)]
        public IntPtr ArbiterInterface;
        [FieldOffset(32)]
        public IntPtr DeviceNode;
        [FieldOffset(40)]
        public _LIST_ENTRY ResourceList;
        [FieldOffset(56)]
        public _LIST_ENTRY BestResourceList;
        [FieldOffset(72)]
        public _LIST_ENTRY BestConfig;
        [FieldOffset(88)]
        public _LIST_ENTRY ActiveArbiterList;
        [FieldOffset(104)]
        public byte State;
        [FieldOffset(105)]
        public byte ResourcesChanged;
    }
}