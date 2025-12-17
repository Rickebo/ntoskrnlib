using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KLDR_DATA_TABLE_ENTRY")]
    public sealed class _KLDR_DATA_TABLE_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY InLoadOrderLinks { get; }
        public IntPtr ExceptionTable { get; }
        public uint ExceptionTableSize { get; }
        public IntPtr GpValue { get; }
        public IntPtr NonPagedDebugInfo { get; }
        public IntPtr DllBase { get; }
        public IntPtr EntryPoint { get; }
        public uint SizeOfImage { get; }
        public _UNICODE_STRING FullDllName { get; }
        public _UNICODE_STRING BaseDllName { get; }
        public uint Flags { get; }
        public ushort LoadCount { get; }
        public _unnamed_tag_ u1 { get; }
        public IntPtr SectionPointer { get; }
        public uint CheckSum { get; }
        public uint CoverageSectionSize { get; }
        public IntPtr CoverageSection { get; }
        public IntPtr LoadedImports { get; }
        public IntPtr Spare { get; }
        public IntPtr NtDataTableEntry { get; }
        public uint SizeOfImageNotRounded { get; }
        public uint TimeDateStamp { get; }

        public _KLDR_DATA_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KLDR_DATA_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.InLoadOrderLinks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.ExceptionTable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.ExceptionTableSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.GpValue),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.NonPagedDebugInfo),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.DllBase),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.EntryPoint),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.SizeOfImage),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.FullDllName),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.BaseDllName),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.Flags),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.LoadCount),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.u1),
                    new ulong[]
                    {
                        110UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.SectionPointer),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.CheckSum),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.CoverageSectionSize),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.CoverageSection),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.LoadedImports),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.Spare),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.NtDataTableEntry),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.SizeOfImageNotRounded),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KLDR_DATA_TABLE_ENTRY.TimeDateStamp),
                    new ulong[]
                    {
                        156UL
                    }
                }
            };
            Register<_KLDR_DATA_TABLE_ENTRY>((mem, ptr) => new _KLDR_DATA_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}