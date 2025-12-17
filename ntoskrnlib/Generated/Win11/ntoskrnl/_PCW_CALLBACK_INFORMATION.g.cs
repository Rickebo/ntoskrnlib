#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _PCW_CALLBACK_INFORMATION
    {
        [FieldOffset(0)]
        public _PCW_COUNTER_INFORMATION AddCounter;
        [FieldOffset(0)]
        public _PCW_COUNTER_INFORMATION RemoveCounter;
        [FieldOffset(0)]
        public _PCW_MASK_INFORMATION EnumerateInstances;
        [FieldOffset(0)]
        public _PCW_MASK_INFORMATION CollectData;
    }
}