using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TP_CALLBACK_ENVIRON_V3")]
    public sealed class _TP_CALLBACK_ENVIRON_V3 : DynamicStructure
    {
        public uint Version { get; }
        public IntPtr Pool { get; }
        public IntPtr CleanupGroup { get; }
        public IntPtr CleanupGroupCancelCallback { get; }
        public IntPtr RaceDll { get; }
        public IntPtr ActivationContext { get; }
        public IntPtr FinalizationCallback { get; }
        public _unnamed_tag_ u { get; }
        public uint CallbackPriority { get; }
        public uint Size { get; }

        public _TP_CALLBACK_ENVIRON_V3(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_CALLBACK_ENVIRON_V3()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.Pool),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.CleanupGroup),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.CleanupGroupCancelCallback),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.RaceDll),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.ActivationContext),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.FinalizationCallback),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.u),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.CallbackPriority),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_ENVIRON_V3.Size),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_TP_CALLBACK_ENVIRON_V3>((mem, ptr) => new _TP_CALLBACK_ENVIRON_V3(mem, ptr), offsets);
        }
    }
}