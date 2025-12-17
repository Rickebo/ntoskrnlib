using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ACCESS_STATE")]
    public sealed class _ACCESS_STATE : DynamicStructure
    {
        public _LUID OperationID { get; }
        public byte SecurityEvaluated { get; }
        public byte GenerateAudit { get; }
        public byte GenerateOnClose { get; }
        public byte PrivilegesAllocated { get; }
        public uint Flags { get; }
        public uint RemainingDesiredAccess { get; }
        public uint PreviouslyGrantedAccess { get; }
        public uint OriginalDesiredAccess { get; }
        public _SECURITY_SUBJECT_CONTEXT SubjectSecurityContext { get; }
        public IntPtr SecurityDescriptor { get; }
        public IntPtr AuxData { get; }
        public _unnamed_tag_ Privileges { get; }
        public byte AuditPrivileges { get; }
        public _UNICODE_STRING ObjectName { get; }
        public _UNICODE_STRING ObjectTypeName { get; }

        public _ACCESS_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACCESS_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACCESS_STATE.OperationID),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.SecurityEvaluated),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.GenerateAudit),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.GenerateOnClose),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.PrivilegesAllocated),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.RemainingDesiredAccess),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.PreviouslyGrantedAccess),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.OriginalDesiredAccess),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.SubjectSecurityContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.SecurityDescriptor),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.AuxData),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.Privileges),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.AuditPrivileges),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.ObjectName),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_ACCESS_STATE.ObjectTypeName),
                    new ulong[]
                    {
                        144UL
                    }
                }
            };
            Register<_ACCESS_STATE>((mem, ptr) => new _ACCESS_STATE(mem, ptr), offsets);
        }
    }
}