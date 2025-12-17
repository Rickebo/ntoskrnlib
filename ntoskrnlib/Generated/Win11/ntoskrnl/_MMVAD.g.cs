#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public partial struct _MMVAD
    {
        [FieldOffset(0)]
        public _MMVAD_SHORT Core;
        [FieldOffset(64)]
        public _MMVAD_FLAGS2 VadFlags2;
        [FieldOffset(72)]
        public IntPtr Subsection;
        [FieldOffset(80)]
        public IntPtr FirstPrototypePte;
        [FieldOffset(88)]
        public IntPtr LastContiguousPte;
        [FieldOffset(96)]
        public _LIST_ENTRY ViewLinks;
        [FieldOffset(112)]
        public IntPtr VadsProcess;
        [FieldOffset(120)]
        public _unnamed_tag_ u4;
        [FieldOffset(128)]
        public IntPtr FileObject;
    }
}