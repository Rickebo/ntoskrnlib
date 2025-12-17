#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _KRESOURCEMANAGER_COMPLETION_BINDING
    {
        [FieldOffset(0)]
        public _LIST_ENTRY NotificationListHead;
        [FieldOffset(16)]
        public IntPtr Port;
        [FieldOffset(24)]
        public ulong Key;
        [FieldOffset(32)]
        public IntPtr BindingProcess;
    }
}