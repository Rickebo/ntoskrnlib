using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ntoskrnlib.Structure;

namespace StructureDemo;

internal static class Program
{
    private static void Main()
    {
        var mem = new SimpleMemorySource(256);

        // Seed memory: write 1234 at address 0x100
        var basePtr = (MemoryPointer)0x100UL;
        mem.Write(basePtr, 1234);

        // Demo 1: reflection-assisted registration via [Offset]
        var d1 = new DynamicStructureService(mem).Read<DemoStruct>(basePtr);
        Console.WriteLine($"DemoStruct.Value={d1.GetValue()}");

        // Demo 2: zero-reflection registration with explicit offset map
        var d2 = new DynamicStructureService(mem).Read<DemoStructZeroReflection>(basePtr);
        Console.WriteLine($"DemoStructZeroReflection.Value={d2.GetValue()}");
    }
}

