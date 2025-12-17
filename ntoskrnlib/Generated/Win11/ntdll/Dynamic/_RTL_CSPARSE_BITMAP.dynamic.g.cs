using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_CSPARSE_BITMAP")]
    public sealed class _RTL_CSPARSE_BITMAP : DynamicStructure
    {
        public IntPtr CommitBitmap { get; }
        public IntPtr UserBitmap { get; }
        public ulong BitCount { get; }
        public ulong BitmapLock { get; }
        public ulong DecommitPageIndex { get; }
        public ulong RtlpCSparseBitmapWakeLock { get; }
        public byte LockType { get; }
        public byte AddressSpace { get; }
        public byte MemType { get; }
        public byte AllocAlignment { get; }
        public uint CommitDirectoryMaxSize { get; }
        public ulong[] CommitDirectory { get; }

        public _RTL_CSPARSE_BITMAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_CSPARSE_BITMAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_CSPARSE_BITMAP.CommitBitmap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.UserBitmap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.BitCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.BitmapLock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.DecommitPageIndex),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.RtlpCSparseBitmapWakeLock),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.LockType),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.AddressSpace),
                    new ulong[]
                    {
                        49UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.MemType),
                    new ulong[]
                    {
                        50UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.AllocAlignment),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.CommitDirectoryMaxSize),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_RTL_CSPARSE_BITMAP.CommitDirectory),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_RTL_CSPARSE_BITMAP>((mem, ptr) => new _RTL_CSPARSE_BITMAP(mem, ptr), offsets);
        }
    }
}