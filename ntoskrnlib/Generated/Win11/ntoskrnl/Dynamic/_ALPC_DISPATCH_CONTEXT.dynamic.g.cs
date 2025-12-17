using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_DISPATCH_CONTEXT")]
    public sealed class _ALPC_DISPATCH_CONTEXT : DynamicStructure
    {
        public IntPtr PortObject { get; }
        public IntPtr Message { get; }
        public IntPtr CommunicationInfo { get; }
        public IntPtr TargetThread { get; }
        public IntPtr TargetPort { get; }
        public _KALPC_DIRECT_EVENT DirectEvent { get; }
        public uint Flags { get; }
        public ushort TotalLength { get; }
        public ushort Type { get; }
        public ushort DataInfoOffset { get; }
        public byte SignalCompletion { get; }
        public byte PostedToCompletionList { get; }

        public _ALPC_DISPATCH_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_DISPATCH_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.PortObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.Message),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.CommunicationInfo),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.TargetThread),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.TargetPort),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.DirectEvent),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.Flags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.TotalLength),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.Type),
                    new ulong[]
                    {
                        54UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.DataInfoOffset),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.SignalCompletion),
                    new ulong[]
                    {
                        58UL
                    }
                },
                {
                    nameof(_ALPC_DISPATCH_CONTEXT.PostedToCompletionList),
                    new ulong[]
                    {
                        59UL
                    }
                }
            };
            Register<_ALPC_DISPATCH_CONTEXT>((mem, ptr) => new _ALPC_DISPATCH_CONTEXT(mem, ptr), offsets);
        }
    }
}