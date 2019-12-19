﻿using System.Collections.Generic;
using Benchmarks.ServerJob;

namespace BenchmarksDriver
{
    public class JobResults
    {
        public Dictionary<string, JobResult> Results { get; set; } = new Dictionary<string, JobResult>();
    }

    public class JobResult
    {
        public MeasurementSummary[] Results { get; set; }
        public MeasurementMetadata[] Metadata { get; set; }
        public List<Measurement[]> Measurements { get; set; } = new List<Measurement[]>();
    }

    public class MeasurementSummary
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}