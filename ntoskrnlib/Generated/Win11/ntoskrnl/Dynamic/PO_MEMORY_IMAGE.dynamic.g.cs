using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!PO_MEMORY_IMAGE")]
    public sealed class PO_MEMORY_IMAGE : DynamicStructure
    {
        public uint Signature { get; }
        public uint ImageType { get; }
        public uint CheckSum { get; }
        public uint LengthSelf { get; }
        public ulong PageSelf { get; }
        public uint PageSize { get; }
        public _LARGE_INTEGER SystemTime { get; }
        public ulong InterruptTime { get; }
        public ulong FeatureFlags { get; }
        public byte HiberFlags { get; }
        public byte HiberSimulateFlags { get; }
        public byte[] spare { get; }
        public uint NoHiberPtes { get; }
        public ulong HiberVa { get; }
        public uint RestoredPagesBitmapSize { get; }
        public uint RestoredPagesBitmapBitmapCheck { get; }
        public uint WakeCheck { get; }
        public ulong NumPagesForLoader { get; }
        public ulong FirstSecureRestorePage { get; }
        public ulong FirstBootRestorePage { get; }
        public ulong FirstKernelRestorePage { get; }
        public ulong FirstChecksumRestorePage { get; }
        public ulong NoChecksumEntries { get; }
        public _PO_HIBER_PERF PerfInfo { get; }
        public uint FirmwareRuntimeInformationPages { get; }
        public ulong[] FirmwareRuntimeInformation { get; }
        public ulong IumFirmwareRuntimeInformationPageCount { get; }
        public ulong IumFirmwareRuntimeInformationPfnBase { get; }
        public uint SpareUlong { get; }
        public uint NoBootLoaderLogPages { get; }
        public ulong[] BootLoaderLogPages { get; }
        public uint NotUsed { get; }
        public uint ResumeContextCheck { get; }
        public uint ResumeContextPages { get; }
        public uint Hiberboot { get; }
        public uint SecureLaunched { get; }
        public uint SecureBoot { get; }
        public uint Fasr { get; }
        public uint HiberResumeXhciHandoffSkip { get; }
        public uint InitializeUSBCore { get; }
        public uint ValidUSBCoreId { get; }
        public uint SkipMemoryMapValidation { get; }
        public uint SuppressResumePrompt { get; }
        public uint Reserved { get; }
        public ulong HvPageTableRoot { get; }
        public ulong HvEntryPoint { get; }
        public ulong HvReservedTransitionAddress { get; }
        public ulong HvReservedTransitionAddressSize { get; }
        public ulong BootFlags { get; }
        public ulong RestoreProcessorStateRoutine { get; }
        public ulong HighestPhysicalPage { get; }
        public ulong[] BitlockerKeyPfns { get; }
        public uint HardwareSignature { get; }
        public _LARGE_INTEGER SMBiosTablePhysicalAddress { get; }
        public uint SMBiosTableLength { get; }
        public byte SMBiosMajorVersion { get; }
        public byte SMBiosMinorVersion { get; }
        public byte USBCoreId { get; }

        public PO_MEMORY_IMAGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static PO_MEMORY_IMAGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(PO_MEMORY_IMAGE.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.ImageType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.CheckSum),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.LengthSelf),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.PageSelf),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.PageSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SystemTime),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.InterruptTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.FeatureFlags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HiberFlags),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HiberSimulateFlags),
                    new ulong[]
                    {
                        57UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.spare),
                    new ulong[]
                    {
                        58UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.NoHiberPtes),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HiberVa),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.RestoredPagesBitmapSize),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.RestoredPagesBitmapBitmapCheck),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.WakeCheck),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.NumPagesForLoader),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.FirstSecureRestorePage),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.FirstBootRestorePage),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.FirstKernelRestorePage),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.FirstChecksumRestorePage),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.NoChecksumEntries),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.PerfInfo),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.FirmwareRuntimeInformationPages),
                    new ulong[]
                    {
                        880UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.FirmwareRuntimeInformation),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.IumFirmwareRuntimeInformationPageCount),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.IumFirmwareRuntimeInformationPfnBase),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SpareUlong),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.NoBootLoaderLogPages),
                    new ulong[]
                    {
                        916UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.BootLoaderLogPages),
                    new ulong[]
                    {
                        920UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.NotUsed),
                    new ulong[]
                    {
                        1112UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.ResumeContextCheck),
                    new ulong[]
                    {
                        1116UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.ResumeContextPages),
                    new ulong[]
                    {
                        1120UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.Hiberboot),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SecureLaunched),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SecureBoot),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.Fasr),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HiberResumeXhciHandoffSkip),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.InitializeUSBCore),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.ValidUSBCoreId),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SkipMemoryMapValidation),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SuppressResumePrompt),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.Reserved),
                    new ulong[]
                    {
                        1124UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HvPageTableRoot),
                    new ulong[]
                    {
                        1128UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HvEntryPoint),
                    new ulong[]
                    {
                        1136UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HvReservedTransitionAddress),
                    new ulong[]
                    {
                        1144UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HvReservedTransitionAddressSize),
                    new ulong[]
                    {
                        1152UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.BootFlags),
                    new ulong[]
                    {
                        1160UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.RestoreProcessorStateRoutine),
                    new ulong[]
                    {
                        1168UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HighestPhysicalPage),
                    new ulong[]
                    {
                        1176UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.BitlockerKeyPfns),
                    new ulong[]
                    {
                        1184UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.HardwareSignature),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SMBiosTablePhysicalAddress),
                    new ulong[]
                    {
                        1224UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SMBiosTableLength),
                    new ulong[]
                    {
                        1232UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SMBiosMajorVersion),
                    new ulong[]
                    {
                        1236UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.SMBiosMinorVersion),
                    new ulong[]
                    {
                        1237UL
                    }
                },
                {
                    nameof(PO_MEMORY_IMAGE.USBCoreId),
                    new ulong[]
                    {
                        1238UL
                    }
                }
            };
            Register<PO_MEMORY_IMAGE>((mem, ptr) => new PO_MEMORY_IMAGE(mem, ptr), offsets);
        }
    }
}