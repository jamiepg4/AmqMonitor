﻿// The MIT License (MIT)
// Copyright (c) 2014 Practice Fusion
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// File:    PerfCounters.cs
// Date:    05/19/2014
// Author:  Steven Padfield
// 
// From Practice Fusion technology blog post, "Windows Performance Counters for ActiveMQ", http://www.practicefusion.com/blog/performance-counters-for-activemq/

using System.Diagnostics;
using PerformanceCounterHelper;

namespace AmqMonitor
{
    /// <summary>
    /// List of performance counters defined by this application.
    /// </summary>
    [PerformanceCounterCategory("AmqMonitor", PerformanceCounterCategoryType.MultiInstance, "Provides counters to monitor queue statistics in ActiveMQ.")]
    public enum PerfCounters
    {
        /// <summary>
        /// The current number of pending messages in the queue.
        /// </summary>
        [PerformanceCounter("Queue depth", "The current number of pending messages in the queue.", PerformanceCounterType.NumberOfItems32)]
        QueueDepth,

        /// <summary>
        /// The rate of messages being added to the queue.
        /// </summary>
        [PerformanceCounter("Enqueued per min", "The rate of messages being added to the queue.", PerformanceCounterType.AverageCount64)]
        EnqueuedPerMin,

        /// <summary>
        /// The rate of messages being removed from the queue.
        /// </summary>
        [PerformanceCounter("Dequeued per min", "The rate of messages being removed from the queue.", PerformanceCounterType.AverageCount64)]
        DequeuedPerMin,
    }
}