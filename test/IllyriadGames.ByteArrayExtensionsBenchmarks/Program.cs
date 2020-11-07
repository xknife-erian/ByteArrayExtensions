﻿// Copyright (c) 2015 Illyriad Games Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.md in the project root for license information.

using BenchmarkDotNet;
using BenchmarkDotNet.Running;

namespace IllyriadGames.ByteArrayExtensionsBenchmarks
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<VectorizedCopyBenchmark>();
        }
    }
}