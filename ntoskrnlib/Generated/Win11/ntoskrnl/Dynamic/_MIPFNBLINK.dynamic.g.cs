using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MIPFNBLINK")]
    public sealed class _MIPFNBLINK : DynamicStructure
    {
        public ulong Blink { get; }
        public ulong NodeBlinkLow { get; }
        public ulong TbFlushStamp { get; }
        public ulong PageBlinkDeleteBit { get; }
        public ulong PageBlinkLockBit { get; }
        public ulong ShareCount { get; }
        public ulong PageShareCountDeleteBit { get; }
        public ulong PageShareCountLockBit { get; }
        public long EntireField { get; }
        public ulong LockNotUsed { get; }
        public ulong DeleteBit { get; }
        public ulong LockBit { get; }

        public _MIPFNBLINK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MIPFNBLINK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MIPFNBLINK.Blink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.NodeBlinkLow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.TbFlushStamp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.PageBlinkDeleteBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.PageBlinkLockBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.ShareCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.PageShareCountDeleteBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.PageShareCountLockBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.LockNotUsed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.DeleteBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MIPFNBLINK.LockBit),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MIPFNBLINK>((mem, ptr) => new _MIPFNBLINK(mem, ptr), offsets);
        }
    }
}