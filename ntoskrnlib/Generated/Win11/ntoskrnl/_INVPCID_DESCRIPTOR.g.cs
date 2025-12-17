#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _INVPCID_DESCRIPTOR
    {
        [FieldOffset(0)]
        public _unnamed_tag_ IndividualAddress;
        [FieldOffset(0)]
        public _unnamed_tag_ SingleContext;
        [FieldOffset(0)]
        public _unnamed_tag_ AllContextAndGlobals;
        [FieldOffset(0)]
        public _unnamed_tag_ AllContext;
    }
}