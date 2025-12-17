using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_LOGON_SESSION_REFERENCES")]
    public sealed class _SEP_LOGON_SESSION_REFERENCES : DynamicStructure
    {
        public IntPtr Next { get; }
        public _LUID LogonId { get; }
        public _LUID BuddyLogonId { get; }
        public _LUID ShadowBuddyLogonId { get; }
        public long ReferenceCount { get; }
        public uint Flags { get; }
        public IntPtr pDeviceMap { get; }
        public IntPtr Token { get; }
        public _UNICODE_STRING AccountName { get; }
        public _UNICODE_STRING AuthorityName { get; }
        public _SEP_CACHED_HANDLES_TABLE CachedHandlesTable { get; }
        public _EX_PUSH_LOCK SharedDataLock { get; }
        public IntPtr SharedClaimAttributes { get; }
        public IntPtr SharedSidValues { get; }
        public _OB_HANDLE_REVOCATION_BLOCK RevocationBlock { get; }
        public IntPtr ServerSilo { get; }
        public _LUID SiblingAuthId { get; }
        public _LIST_ENTRY TokenList { get; }

        public _SEP_LOGON_SESSION_REFERENCES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_LOGON_SESSION_REFERENCES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.LogonId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.BuddyLogonId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.ShadowBuddyLogonId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.ReferenceCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.Flags),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.pDeviceMap),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.Token),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.AccountName),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.AuthorityName),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.CachedHandlesTable),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.SharedDataLock),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.SharedClaimAttributes),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.SharedSidValues),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.RevocationBlock),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.ServerSilo),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.SiblingAuthId),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_SEP_LOGON_SESSION_REFERENCES.TokenList),
                    new ulong[]
                    {
                        184UL
                    }
                }
            };
            Register<_SEP_LOGON_SESSION_REFERENCES>((mem, ptr) => new _SEP_LOGON_SESSION_REFERENCES(mem, ptr), offsets);
        }
    }
}