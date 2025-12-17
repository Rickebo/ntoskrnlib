using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_SECURITY_CACHE_ENTRY")]
    public sealed class _CM_KEY_SECURITY_CACHE_ENTRY : DynamicStructure
    {
        public uint Cell { get; }
        public IntPtr CachedSecurity { get; }

        public _CM_KEY_SECURITY_CACHE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_SECURITY_CACHE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_SECURITY_CACHE_ENTRY.Cell),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_SECURITY_CACHE_ENTRY.CachedSecurity),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CM_KEY_SECURITY_CACHE_ENTRY>((mem, ptr) => new _CM_KEY_SECURITY_CACHE_ENTRY(mem, ptr), offsets);
        }
    }
}