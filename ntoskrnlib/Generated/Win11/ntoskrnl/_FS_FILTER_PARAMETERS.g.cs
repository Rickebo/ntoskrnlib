#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _FS_FILTER_PARAMETERS
    {
        [FieldOffset(0)]
        public _unnamed_tag_ AcquireForModifiedPageWriter;
        [FieldOffset(0)]
        public _unnamed_tag_ ReleaseForModifiedPageWriter;
        [FieldOffset(0)]
        public _unnamed_tag_ AcquireForSectionSynchronization;
        [FieldOffset(0)]
        public _unnamed_tag_ QueryOpen;
        [FieldOffset(0)]
        public _unnamed_tag_ Others;
    }
}