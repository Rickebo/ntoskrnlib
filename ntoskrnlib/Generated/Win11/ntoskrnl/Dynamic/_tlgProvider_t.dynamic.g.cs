using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_tlgProvider_t")]
    public sealed class _tlgProvider_t : DynamicStructure
    {
        public uint LevelPlus1 { get; }
        public IntPtr ProviderMetadataPtr { get; }
        public ulong KeywordAny { get; }
        public ulong KeywordAll { get; }
        public ulong RegHandle { get; }
        public IntPtr EnableCallback { get; }
        public IntPtr CallbackContext { get; }

        public _tlgProvider_t(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _tlgProvider_t()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_tlgProvider_t.LevelPlus1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_tlgProvider_t.ProviderMetadataPtr),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_tlgProvider_t.KeywordAny),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_tlgProvider_t.KeywordAll),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_tlgProvider_t.RegHandle),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_tlgProvider_t.EnableCallback),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_tlgProvider_t.CallbackContext),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_tlgProvider_t>((mem, ptr) => new _tlgProvider_t(mem, ptr), offsets);
        }
    }
}