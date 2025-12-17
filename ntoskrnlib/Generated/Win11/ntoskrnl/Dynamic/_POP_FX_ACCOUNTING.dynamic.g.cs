using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_ACCOUNTING")]
    public sealed class _POP_FX_ACCOUNTING : DynamicStructure
    {
        public ulong Lock { get; }
        public byte Active { get; }
        public uint DripsRequiredState { get; }
        public uint AccountingMode { get; }
        public ulong ActiveStamp { get; }
        public _POP_FX_ACTIVE_TIME_ACCOUNTING CsActiveTimeAccounting { get; }
        public _POP_FX_ACTIVE_TIME_ACCOUNTING CsCriticalActiveTimeAccounting { get; }

        public _POP_FX_ACCOUNTING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_ACCOUNTING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_ACCOUNTING.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_ACCOUNTING.Active),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_ACCOUNTING.DripsRequiredState),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POP_FX_ACCOUNTING.AccountingMode),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_ACCOUNTING.ActiveStamp),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_FX_ACCOUNTING.CsActiveTimeAccounting),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_FX_ACCOUNTING.CsCriticalActiveTimeAccounting),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_POP_FX_ACCOUNTING>((mem, ptr) => new _POP_FX_ACCOUNTING(mem, ptr), offsets);
        }
    }
}