#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _OBJECT_HEADER
    {
        [FieldOffset(0)]
        public long PointerCount;
        [FieldOffset(8)]
        public long HandleCount;
        [FieldOffset(8)]
        public IntPtr NextToFree;
        [FieldOffset(16)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(24)]
        public byte TypeIndex;
        [FieldOffset(25)]
        public byte TraceFlags;
        [FieldOffset(25)]
        public byte DbgRefTrace;
        [FieldOffset(25)]
        public byte DbgTracePermanent;
        [FieldOffset(26)]
        public byte InfoMask;
        [FieldOffset(27)]
        public byte Flags;
        [FieldOffset(27)]
        public byte NewObject;
        [FieldOffset(27)]
        public byte KernelObject;
        [FieldOffset(27)]
        public byte KernelOnlyAccess;
        [FieldOffset(27)]
        public byte ExclusiveObject;
        [FieldOffset(27)]
        public byte PermanentObject;
        [FieldOffset(27)]
        public byte DefaultSecurityQuota;
        [FieldOffset(27)]
        public byte SingleHandleEntry;
        [FieldOffset(27)]
        public byte DeletedInline;
        [FieldOffset(28)]
        public uint Reserved;
        [FieldOffset(32)]
        public IntPtr ObjectCreateInfo;
        [FieldOffset(32)]
        public IntPtr QuotaBlockCharged;
        [FieldOffset(40)]
        public IntPtr SecurityDescriptor;
        [FieldOffset(48)]
        public _QUAD Body;
    }
}