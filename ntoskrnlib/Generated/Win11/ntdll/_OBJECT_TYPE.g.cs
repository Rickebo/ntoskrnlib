#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public partial struct _OBJECT_TYPE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY TypeList;
        [FieldOffset(16)]
        public _UNICODE_STRING Name;
        [FieldOffset(32)]
        public IntPtr DefaultObject;
        [FieldOffset(40)]
        public byte Index;
        [FieldOffset(44)]
        public uint TotalNumberOfObjects;
        [FieldOffset(48)]
        public uint TotalNumberOfHandles;
        [FieldOffset(52)]
        public uint HighWaterNumberOfObjects;
        [FieldOffset(56)]
        public uint HighWaterNumberOfHandles;
        [FieldOffset(64)]
        public _OBJECT_TYPE_INITIALIZER TypeInfo;
        [FieldOffset(184)]
        public _EX_PUSH_LOCK TypeLock;
        [FieldOffset(192)]
        public uint Key;
        [FieldOffset(200)]
        public _LIST_ENTRY CallbackList;
        [FieldOffset(216)]
        public uint SeMandatoryLabelMask;
        [FieldOffset(220)]
        public uint SeTrustConstraintMask;
    }
}