using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED")]
    public sealed class _RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED : DynamicStructure
    {
        public ulong Size { get; }
        public uint Format { get; }
        public _RTL_ACTIVATION_CONTEXT_STACK_FRAME Frame { get; }
        public IntPtr Extra1 { get; }
        public IntPtr Extra2 { get; }
        public IntPtr Extra3 { get; }
        public IntPtr Extra4 { get; }

        public _RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED.Format),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED.Frame),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED.Extra1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED.Extra2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED.Extra3),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED.Extra4),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED>((mem, ptr) => new _RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED(mem, ptr), offsets);
        }
    }
}