using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_LOG_REGISTER_CONTEXT")]
    public sealed class _HAL_LOG_REGISTER_CONTEXT : DynamicStructure
    {
        public IntPtr LogRoutine { get; }
        public uint Flag { get; }

        public _HAL_LOG_REGISTER_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_LOG_REGISTER_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_LOG_REGISTER_CONTEXT.LogRoutine),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_LOG_REGISTER_CONTEXT.Flag),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HAL_LOG_REGISTER_CONTEXT>((mem, ptr) => new _HAL_LOG_REGISTER_CONTEXT(mem, ptr), offsets);
        }
    }
}