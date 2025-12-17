using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION")]
    public sealed class _FAULT_INFORMATION : DynamicStructure
    {
        public uint Type { get; }
        public byte IsStage1 { get; }
        public _FAULT_INFORMATION_ARM64 Arm64 { get; }
        public _FAULT_INFORMATION_X64 X64 { get; }

        public _FAULT_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAULT_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAULT_INFORMATION.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION.IsStage1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION.Arm64),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FAULT_INFORMATION.X64),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_FAULT_INFORMATION>((mem, ptr) => new _FAULT_INFORMATION(mem, ptr), offsets);
        }
    }
}