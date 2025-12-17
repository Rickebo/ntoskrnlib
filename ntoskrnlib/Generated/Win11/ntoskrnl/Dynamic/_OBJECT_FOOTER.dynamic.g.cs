using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_FOOTER")]
    public sealed class _OBJECT_FOOTER : DynamicStructure
    {
        public _HANDLE_REVOCATION_INFO HandleRevocationInfo { get; }
        public _OB_EXTENDED_USER_INFO ExtendedUserInfo { get; }

        public _OBJECT_FOOTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_FOOTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_FOOTER.HandleRevocationInfo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_FOOTER.ExtendedUserInfo),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_OBJECT_FOOTER>((mem, ptr) => new _OBJECT_FOOTER(mem, ptr), offsets);
        }
    }
}