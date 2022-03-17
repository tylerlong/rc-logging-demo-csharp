// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using RingCentral;

Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

var rc = new RestClient("fake", "fake", "https://platform.ringcentral.com");
await rc.Authorize("fake", "", "fake");
