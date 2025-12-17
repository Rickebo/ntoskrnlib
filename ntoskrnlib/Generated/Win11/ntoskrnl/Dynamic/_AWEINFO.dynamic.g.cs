using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_AWEINFO")]
    public sealed class _AWEINFO : DynamicStructure
    {
        public IntPtr AweInfoSignature { get; }
        public _MI_AWEINFO_FLAGS Flags { get; }
        public ulong PageSize { get; }
        public _RTL_BITMAP_EX VadPhysicalPagesBitMap { get; }
        public IntPtr ControlArea { get; }
        public int ChangeClusterAttributeLock { get; }
        public uint CacheAttribute { get; }
        public _EX_PUSH_LOCK_AUTO_EXPAND AwePagesLock { get; }
        public IntPtr ChangeClusterAttributeWaitList { get; }

        public _AWEINFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AWEINFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AWEINFO.AweInfoSignature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AWEINFO.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_AWEINFO.PageSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_AWEINFO.VadPhysicalPagesBitMap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_AWEINFO.ControlArea),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_AWEINFO.ChangeClusterAttributeLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_AWEINFO.CacheAttribute),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_AWEINFO.AwePagesLock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_AWEINFO.ChangeClusterAttributeWaitList),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_AWEINFO>((mem, ptr) => new _AWEINFO(mem, ptr), offsets);
        }
    }
}