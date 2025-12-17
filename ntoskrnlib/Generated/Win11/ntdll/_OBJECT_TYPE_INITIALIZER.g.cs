#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _OBJECT_TYPE_INITIALIZER
    {
        [FieldOffset(0)]
        public ushort Length;
        [FieldOffset(2)]
        public ushort ObjectTypeFlags;
        [FieldOffset(2)]
        public byte CaseInsensitive;
        [FieldOffset(2)]
        public byte UnnamedObjectsOnly;
        [FieldOffset(2)]
        public byte UseDefaultObject;
        [FieldOffset(2)]
        public byte SecurityRequired;
        [FieldOffset(2)]
        public byte MaintainHandleCount;
        [FieldOffset(2)]
        public byte MaintainTypeList;
        [FieldOffset(2)]
        public byte SupportsObjectCallbacks;
        [FieldOffset(2)]
        public byte CacheAligned;
        [FieldOffset(3)]
        public byte UseExtendedParameters;
        [FieldOffset(3)]
        public byte SeTrustConstraintMaskPresent;
        [FieldOffset(3)]
        public byte Reserved;
        [FieldOffset(4)]
        public uint ObjectTypeCode;
        [FieldOffset(8)]
        public uint InvalidAttributes;
        [FieldOffset(12)]
        public _GENERIC_MAPPING GenericMapping;
        [FieldOffset(28)]
        public uint ValidAccessMask;
        [FieldOffset(32)]
        public uint RetainAccess;
        [FieldOffset(36)]
        public uint PoolType;
        [FieldOffset(40)]
        public uint DefaultPagedPoolCharge;
        [FieldOffset(44)]
        public uint DefaultNonPagedPoolCharge;
        [FieldOffset(48)]
        public IntPtr DumpProcedure;
        [FieldOffset(56)]
        public IntPtr OpenProcedure;
        [FieldOffset(64)]
        public IntPtr CloseProcedure;
        [FieldOffset(72)]
        public IntPtr DeleteProcedure;
        [FieldOffset(80)]
        public IntPtr ParseProcedure;
        [FieldOffset(80)]
        public IntPtr ParseProcedureEx;
        [FieldOffset(88)]
        public IntPtr SecurityProcedure;
        [FieldOffset(96)]
        public IntPtr QueryNameProcedure;
        [FieldOffset(104)]
        public IntPtr OkayToCloseProcedure;
        [FieldOffset(112)]
        public uint WaitObjectFlagMask;
        [FieldOffset(116)]
        public ushort WaitObjectFlagOffset;
        [FieldOffset(118)]
        public ushort WaitObjectPointerOffset;
    }
}