using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FIRMWARE_INFORMATION_LOADER_BLOCK")]
    public sealed class _FIRMWARE_INFORMATION_LOADER_BLOCK : DynamicStructure
    {
        public uint FirmwareTypeUefi { get; }
        public uint EfiRuntimeUseIum { get; }
        public uint EfiRuntimePageProtectionSupported { get; }
        public uint Reserved1 { get; }
        public uint SoftRebootMpwrResume { get; }
        public uint Reserved2 { get; }
        public _unnamed_tag_ u { get; }

        public _FIRMWARE_INFORMATION_LOADER_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FIRMWARE_INFORMATION_LOADER_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FIRMWARE_INFORMATION_LOADER_BLOCK.FirmwareTypeUefi),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FIRMWARE_INFORMATION_LOADER_BLOCK.EfiRuntimeUseIum),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FIRMWARE_INFORMATION_LOADER_BLOCK.EfiRuntimePageProtectionSupported),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FIRMWARE_INFORMATION_LOADER_BLOCK.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FIRMWARE_INFORMATION_LOADER_BLOCK.SoftRebootMpwrResume),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FIRMWARE_INFORMATION_LOADER_BLOCK.Reserved2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FIRMWARE_INFORMATION_LOADER_BLOCK.u),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_FIRMWARE_INFORMATION_LOADER_BLOCK>((mem, ptr) => new _FIRMWARE_INFORMATION_LOADER_BLOCK(mem, ptr), offsets);
        }
    }
}