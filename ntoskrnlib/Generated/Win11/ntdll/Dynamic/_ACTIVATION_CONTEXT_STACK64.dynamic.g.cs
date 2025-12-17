using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ACTIVATION_CONTEXT_STACK64")]
    public sealed class _ACTIVATION_CONTEXT_STACK64 : DynamicStructure
    {
        public ulong ActiveFrame { get; }
        public LIST_ENTRY64 FrameListCache { get; }
        public uint Flags { get; }
        public uint NextCookieSequenceNumber { get; }
        public uint StackId { get; }

        public _ACTIVATION_CONTEXT_STACK64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACTIVATION_CONTEXT_STACK64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACTIVATION_CONTEXT_STACK64.ActiveFrame),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK64.FrameListCache),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK64.Flags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK64.NextCookieSequenceNumber),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK64.StackId),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_ACTIVATION_CONTEXT_STACK64>((mem, ptr) => new _ACTIVATION_CONTEXT_STACK64(mem, ptr), offsets);
        }
    }
}