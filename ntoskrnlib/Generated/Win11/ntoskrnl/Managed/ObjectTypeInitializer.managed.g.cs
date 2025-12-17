using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_TYPE_INITIALIZER")]
    public sealed class ObjectTypeInitializer : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Length { get => ReadHere<ushort>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort ObjectTypeFlags { get => ReadHere<ushort>(nameof(ObjectTypeFlags)); set => WriteHere(nameof(ObjectTypeFlags), value); }

        [Offset(2UL)]
        public byte CaseInsensitive { get => ReadHere<byte>(nameof(CaseInsensitive)); set => WriteHere(nameof(CaseInsensitive), value); }

        [Offset(2UL)]
        public byte UnnamedObjectsOnly { get => ReadHere<byte>(nameof(UnnamedObjectsOnly)); set => WriteHere(nameof(UnnamedObjectsOnly), value); }

        [Offset(2UL)]
        public byte UseDefaultObject { get => ReadHere<byte>(nameof(UseDefaultObject)); set => WriteHere(nameof(UseDefaultObject), value); }

        [Offset(2UL)]
        public byte SecurityRequired { get => ReadHere<byte>(nameof(SecurityRequired)); set => WriteHere(nameof(SecurityRequired), value); }

        [Offset(2UL)]
        public byte MaintainHandleCount { get => ReadHere<byte>(nameof(MaintainHandleCount)); set => WriteHere(nameof(MaintainHandleCount), value); }

        [Offset(2UL)]
        public byte MaintainTypeList { get => ReadHere<byte>(nameof(MaintainTypeList)); set => WriteHere(nameof(MaintainTypeList), value); }

        [Offset(2UL)]
        public byte SupportsObjectCallbacks { get => ReadHere<byte>(nameof(SupportsObjectCallbacks)); set => WriteHere(nameof(SupportsObjectCallbacks), value); }

        [Offset(2UL)]
        public byte CacheAligned { get => ReadHere<byte>(nameof(CacheAligned)); set => WriteHere(nameof(CacheAligned), value); }

        [Offset(3UL)]
        public byte UseExtendedParameters { get => ReadHere<byte>(nameof(UseExtendedParameters)); set => WriteHere(nameof(UseExtendedParameters), value); }

        [Offset(3UL)]
        public byte SeTrustConstraintMaskPresent { get => ReadHere<byte>(nameof(SeTrustConstraintMaskPresent)); set => WriteHere(nameof(SeTrustConstraintMaskPresent), value); }

        [Offset(3UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint ObjectTypeCode { get => ReadHere<uint>(nameof(ObjectTypeCode)); set => WriteHere(nameof(ObjectTypeCode), value); }

        [Offset(8UL)]
        public uint InvalidAttributes { get => ReadHere<uint>(nameof(InvalidAttributes)); set => WriteHere(nameof(InvalidAttributes), value); }

        [Offset(12UL)]
        public GenericMapping GenericMapping { get => ReadStructure<GenericMapping>(nameof(GenericMapping)); set => WriteStructure(nameof(GenericMapping), value); }

        [Offset(28UL)]
        public uint ValidAccessMask { get => ReadHere<uint>(nameof(ValidAccessMask)); set => WriteHere(nameof(ValidAccessMask), value); }

        [Offset(32UL)]
        public uint RetainAccess { get => ReadHere<uint>(nameof(RetainAccess)); set => WriteHere(nameof(RetainAccess), value); }

        [Offset(36UL)]
        public uint PoolType { get => ReadHere<uint>(nameof(PoolType)); set => WriteHere(nameof(PoolType), value); }

        [Offset(40UL)]
        public uint DefaultPagedPoolCharge { get => ReadHere<uint>(nameof(DefaultPagedPoolCharge)); set => WriteHere(nameof(DefaultPagedPoolCharge), value); }

        [Offset(44UL)]
        public uint DefaultNonPagedPoolCharge { get => ReadHere<uint>(nameof(DefaultNonPagedPoolCharge)); set => WriteHere(nameof(DefaultNonPagedPoolCharge), value); }

        [Offset(48UL)]
        public IntPtr DumpProcedure { get => ReadHere<IntPtr>(nameof(DumpProcedure)); set => WriteHere(nameof(DumpProcedure), value); }

        [Offset(56UL)]
        public IntPtr OpenProcedure { get => ReadHere<IntPtr>(nameof(OpenProcedure)); set => WriteHere(nameof(OpenProcedure), value); }

        [Offset(64UL)]
        public IntPtr CloseProcedure { get => ReadHere<IntPtr>(nameof(CloseProcedure)); set => WriteHere(nameof(CloseProcedure), value); }

        [Offset(72UL)]
        public IntPtr DeleteProcedure { get => ReadHere<IntPtr>(nameof(DeleteProcedure)); set => WriteHere(nameof(DeleteProcedure), value); }

        [Offset(80UL)]
        public IntPtr ParseProcedure { get => ReadHere<IntPtr>(nameof(ParseProcedure)); set => WriteHere(nameof(ParseProcedure), value); }

        [Offset(80UL)]
        public IntPtr ParseProcedureEx { get => ReadHere<IntPtr>(nameof(ParseProcedureEx)); set => WriteHere(nameof(ParseProcedureEx), value); }

        [Offset(88UL)]
        public IntPtr SecurityProcedure { get => ReadHere<IntPtr>(nameof(SecurityProcedure)); set => WriteHere(nameof(SecurityProcedure), value); }

        [Offset(96UL)]
        public IntPtr QueryNameProcedure { get => ReadHere<IntPtr>(nameof(QueryNameProcedure)); set => WriteHere(nameof(QueryNameProcedure), value); }

        [Offset(104UL)]
        public IntPtr OkayToCloseProcedure { get => ReadHere<IntPtr>(nameof(OkayToCloseProcedure)); set => WriteHere(nameof(OkayToCloseProcedure), value); }

        [Offset(112UL)]
        public uint WaitObjectFlagMask { get => ReadHere<uint>(nameof(WaitObjectFlagMask)); set => WriteHere(nameof(WaitObjectFlagMask), value); }

        [Offset(116UL)]
        public ushort WaitObjectFlagOffset { get => ReadHere<ushort>(nameof(WaitObjectFlagOffset)); set => WriteHere(nameof(WaitObjectFlagOffset), value); }

        [Offset(118UL)]
        public ushort WaitObjectPointerOffset { get => ReadHere<ushort>(nameof(WaitObjectPointerOffset)); set => WriteHere(nameof(WaitObjectPointerOffset), value); }

        public ObjectTypeInitializer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectTypeInitializer>();
        }
    }
}