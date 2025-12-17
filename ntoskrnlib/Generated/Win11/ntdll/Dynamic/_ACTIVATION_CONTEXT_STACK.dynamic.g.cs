using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ACTIVATION_CONTEXT_STACK")]
    public sealed class _ACTIVATION_CONTEXT_STACK : DynamicStructure
    {
        public IntPtr ActiveFrame { get; }
        public _LIST_ENTRY FrameListCache { get; }
        public uint Flags { get; }
        public uint NextCookieSequenceNumber { get; }
        public uint StackId { get; }

        public _ACTIVATION_CONTEXT_STACK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACTIVATION_CONTEXT_STACK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACTIVATION_CONTEXT_STACK.ActiveFrame),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK.FrameListCache),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK.Flags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK.NextCookieSequenceNumber),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK.StackId),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_ACTIVATION_CONTEXT_STACK>((mem, ptr) => new _ACTIVATION_CONTEXT_STACK(mem, ptr), offsets);
        }
    }
}