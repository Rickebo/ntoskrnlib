#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_PFN_FLAGS5
    {
        [FieldOffset(0)]
        public uint EntireField;
        [FieldOffset(0)]
        public _unnamed_tag_ StandbyList;
        [FieldOffset(0)]
        public _unnamed_tag_ MappedPageList;
        [FieldOffset(0)]
        public _unnamed_tag_ Active;
    }
}