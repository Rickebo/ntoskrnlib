using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_WAIT")]
    public sealed class _TP_WAIT : DynamicStructure
    {
        public _TP_TIMER Timer { get; }
        public IntPtr Handle { get; }
        public IntPtr WaitPkt { get; }
        public IntPtr NextWaitHandle { get; }
        public _LARGE_INTEGER NextWaitTimeout { get; }
        public _TP_DIRECT Direct { get; }
        public _unnamed_tag_ WaitFlags { get; }

        public _TP_WAIT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_WAIT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_WAIT.Timer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_WAIT.Handle),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_TP_WAIT.WaitPkt),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_TP_WAIT.NextWaitHandle),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_TP_WAIT.NextWaitTimeout),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_TP_WAIT.Direct),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_TP_WAIT.WaitFlags),
                    new ulong[]
                    {
                        464UL
                    }
                }
            };
            Register<_TP_WAIT>((mem, ptr) => new _TP_WAIT(mem, ptr), offsets);
        }
    }
}