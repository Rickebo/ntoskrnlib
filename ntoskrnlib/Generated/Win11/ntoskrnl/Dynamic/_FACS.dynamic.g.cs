using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FACS")]
    public sealed class _FACS : DynamicStructure
    {
        public uint Signature { get; }
        public uint Length { get; }
        public uint HardwareSignature { get; }
        public uint pFirmwareWakingVector { get; }
        public uint GlobalLock { get; }
        public uint Flags { get; }
        public _LARGE_INTEGER x_FirmwareWakingVector { get; }
        public byte version { get; }
        public byte[] Reserved { get; }

        public _FACS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FACS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FACS.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FACS.Length),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_FACS.HardwareSignature),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FACS.pFirmwareWakingVector),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_FACS.GlobalLock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FACS.Flags),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_FACS.x_FirmwareWakingVector),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FACS.version),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_FACS.Reserved),
                    new ulong[]
                    {
                        33UL
                    }
                }
            };
            Register<_FACS>((mem, ptr) => new _FACS(mem, ptr), offsets);
        }
    }
}