using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ACCESS_STATE")]
    public sealed class AccessState : DynamicStructure
    {
        [Offset(0UL)]
        public Luid OperationID { get => ReadStructure<Luid>(nameof(OperationID)); set => WriteStructure(nameof(OperationID), value); }

        [Offset(8UL)]
        public byte SecurityEvaluated { get => ReadHere<byte>(nameof(SecurityEvaluated)); set => WriteHere(nameof(SecurityEvaluated), value); }

        [Offset(9UL)]
        public byte GenerateAudit { get => ReadHere<byte>(nameof(GenerateAudit)); set => WriteHere(nameof(GenerateAudit), value); }

        [Offset(10UL)]
        public byte GenerateOnClose { get => ReadHere<byte>(nameof(GenerateOnClose)); set => WriteHere(nameof(GenerateOnClose), value); }

        [Offset(11UL)]
        public byte PrivilegesAllocated { get => ReadHere<byte>(nameof(PrivilegesAllocated)); set => WriteHere(nameof(PrivilegesAllocated), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public uint RemainingDesiredAccess { get => ReadHere<uint>(nameof(RemainingDesiredAccess)); set => WriteHere(nameof(RemainingDesiredAccess), value); }

        [Offset(20UL)]
        public uint PreviouslyGrantedAccess { get => ReadHere<uint>(nameof(PreviouslyGrantedAccess)); set => WriteHere(nameof(PreviouslyGrantedAccess), value); }

        [Offset(24UL)]
        public uint OriginalDesiredAccess { get => ReadHere<uint>(nameof(OriginalDesiredAccess)); set => WriteHere(nameof(OriginalDesiredAccess), value); }

        [Offset(32UL)]
        public SecuritySubjectContext SubjectSecurityContext { get => ReadStructure<SecuritySubjectContext>(nameof(SubjectSecurityContext)); set => WriteStructure(nameof(SubjectSecurityContext), value); }

        [Offset(64UL)]
        public IntPtr SecurityDescriptor { get => ReadHere<IntPtr>(nameof(SecurityDescriptor)); set => WriteHere(nameof(SecurityDescriptor), value); }

        [Offset(72UL)]
        public IntPtr AuxData { get => ReadHere<IntPtr>(nameof(AuxData)); set => WriteHere(nameof(AuxData), value); }

        [Offset(80UL)]
        public UnnamedTag Privileges { get => ReadStructure<UnnamedTag>(nameof(Privileges)); set => WriteStructure(nameof(Privileges), value); }

        [Offset(124UL)]
        public byte AuditPrivileges { get => ReadHere<byte>(nameof(AuditPrivileges)); set => WriteHere(nameof(AuditPrivileges), value); }

        [Offset(128UL)]
        public UnicodeString ObjectName { get => ReadStructure<UnicodeString>(nameof(ObjectName)); set => WriteStructure(nameof(ObjectName), value); }

        [Offset(144UL)]
        public UnicodeString ObjectTypeName { get => ReadStructure<UnicodeString>(nameof(ObjectTypeName)); set => WriteStructure(nameof(ObjectTypeName), value); }

        public AccessState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AccessState>();
        }
    }
}