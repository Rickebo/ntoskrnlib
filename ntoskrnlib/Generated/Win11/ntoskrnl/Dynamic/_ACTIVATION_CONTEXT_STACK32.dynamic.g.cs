using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ACTIVATION_CONTEXT_STACK32")]
    public sealed class _ACTIVATION_CONTEXT_STACK32 : DynamicStructure
    {
        public uint ActiveFrame { get; }
        public LIST_ENTRY32 FrameListCache { get; }
        public uint Flags { get; }
        public uint NextCookieSequenceNumber { get; }
        public uint StackId { get; }

        public _ACTIVATION_CONTEXT_STACK32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ACTIVATION_CONTEXT_STACK32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ACTIVATION_CONTEXT_STACK32.ActiveFrame),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK32.FrameListCache),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK32.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK32.NextCookieSequenceNumber),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ACTIVATION_CONTEXT_STACK32.StackId),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_ACTIVATION_CONTEXT_STACK32>((mem, ptr) => new _ACTIVATION_CONTEXT_STACK32(mem, ptr), offsets);
        }
    }
}