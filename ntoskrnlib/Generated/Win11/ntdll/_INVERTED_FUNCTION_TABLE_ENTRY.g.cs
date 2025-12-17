#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _INVERTED_FUNCTION_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr FunctionTable;
        [FieldOffset(0)]
        public IntPtr DynamicTable;
        [FieldOffset(8)]
        public IntPtr ImageBase;
        [FieldOffset(16)]
        public uint SizeOfImage;
        [FieldOffset(20)]
        public uint SizeOfTable;
    }
}