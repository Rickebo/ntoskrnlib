using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KPCR")]
    public sealed class _KPCR : DynamicStructure
    {
        public _NT_TIB NtTib { get; }
        public IntPtr GdtBase { get; }
        public IntPtr TssBase { get; }
        public ulong UserRsp { get; }
        public IntPtr Self { get; }
        public IntPtr CurrentPrcb { get; }
        public IntPtr LockArray { get; }
        public IntPtr Used_Self { get; }
        public IntPtr IdtBase { get; }
        public ulong[] Unused { get; }
        public byte Irql { get; }
        public byte SecondLevelCacheAssociativity { get; }
        public byte ObsoleteNumber { get; }
        public byte Fill0 { get; }
        public uint[] Unused0 { get; }
        public ushort MajorVersion { get; }
        public ushort MinorVersion { get; }
        public uint StallScaleFactor { get; }
        public byte[] Unused1 { get; }
        public uint[] KernelReserved { get; }
        public uint SecondLevelCacheSize { get; }
        public uint[] HalReserved { get; }
        public uint Unused2 { get; }
        public IntPtr KdVersionBlock { get; }
        public IntPtr Unused3 { get; }
        public uint[] PcrAlign1 { get; }
        public _KPRCB Prcb { get; }

        public _KPCR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPCR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPCR.NtTib),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPCR.GdtBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPCR.TssBase),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KPCR.UserRsp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KPCR.Self),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KPCR.CurrentPrcb),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KPCR.LockArray),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KPCR.Used_Self),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KPCR.IdtBase),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KPCR.Unused),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KPCR.Irql),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KPCR.SecondLevelCacheAssociativity),
                    new ulong[]
                    {
                        81UL
                    }
                },
                {
                    nameof(_KPCR.ObsoleteNumber),
                    new ulong[]
                    {
                        82UL
                    }
                },
                {
                    nameof(_KPCR.Fill0),
                    new ulong[]
                    {
                        83UL
                    }
                },
                {
                    nameof(_KPCR.Unused0),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_KPCR.MajorVersion),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KPCR.MinorVersion),
                    new ulong[]
                    {
                        98UL
                    }
                },
                {
                    nameof(_KPCR.StallScaleFactor),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_KPCR.Unused1),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KPCR.KernelReserved),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KPCR.SecondLevelCacheSize),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_KPCR.HalReserved),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KPCR.Unused2),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KPCR.KdVersionBlock),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_KPCR.Unused3),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_KPCR.PcrAlign1),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_KPCR.Prcb),
                    new ulong[]
                    {
                        384UL
                    }
                }
            };
            Register<_KPCR>((mem, ptr) => new _KPCR(mem, ptr), offsets);
        }
    }
}