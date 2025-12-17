using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_EXTRA_IMAGE_INFORMATION")]
    public sealed class _MI_EXTRA_IMAGE_INFORMATION : DynamicStructure
    {
        public uint SizeOfHeaders { get; }
        public uint SizeOfImage { get; }
        public uint TimeDateStamp { get; }
        public uint ImageCetShadowStacksReady { get; }
        public uint ImageCetShadowStacksStrictMode { get; }
        public uint ImageCetSetContextIpValidationRelaxedMode { get; }
        public uint ImageCetDynamicApisAllowInProc { get; }
        public uint ImageCetDowngradeReserved1 { get; }
        public uint ImageCetDowngradeReserved2 { get; }
        public uint ImageExpansionCompatible { get; }
        public uint Spare { get; }

        public _MI_EXTRA_IMAGE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_EXTRA_IMAGE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.SizeOfHeaders),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.SizeOfImage),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.TimeDateStamp),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.ImageCetShadowStacksReady),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.ImageCetShadowStacksStrictMode),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.ImageCetSetContextIpValidationRelaxedMode),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.ImageCetDynamicApisAllowInProc),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.ImageCetDowngradeReserved1),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.ImageCetDowngradeReserved2),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.ImageExpansionCompatible),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_EXTRA_IMAGE_INFORMATION.Spare),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_MI_EXTRA_IMAGE_INFORMATION>((mem, ptr) => new _MI_EXTRA_IMAGE_INFORMATION(mem, ptr), offsets);
        }
    }
}