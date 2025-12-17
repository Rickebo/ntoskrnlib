using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HANDLE_REVOCATION_INFO")]
    public sealed class _HANDLE_REVOCATION_INFO : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr RevocationBlock { get; }
        public byte AllowHandleRevocation { get; }
        public byte[] Padding1 { get; }
        public byte[] Padding2 { get; }

        public _HANDLE_REVOCATION_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HANDLE_REVOCATION_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HANDLE_REVOCATION_INFO.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_REVOCATION_INFO.RevocationBlock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HANDLE_REVOCATION_INFO.AllowHandleRevocation),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HANDLE_REVOCATION_INFO.Padding1),
                    new ulong[]
                    {
                        25UL
                    }
                },
                {
                    nameof(_HANDLE_REVOCATION_INFO.Padding2),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_HANDLE_REVOCATION_INFO>((mem, ptr) => new _HANDLE_REVOCATION_INFO(mem, ptr), offsets);
        }
    }
}