#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _VF_TARGET_DRIVER
    {
        [FieldOffset(0)]
        public _VF_AVL_TREE_NODE TreeNode;
        [FieldOffset(16)]
        public _unnamed_tag_ u1;
        [FieldOffset(40)]
        public IntPtr DriverObject;
        [FieldOffset(48)]
        public IntPtr Callbacks;
        [FieldOffset(56)]
        public uint AssignedPluginId;
        [FieldOffset(64)]
        public IntPtr VerifiedData;
    }
}