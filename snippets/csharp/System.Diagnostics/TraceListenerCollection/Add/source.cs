﻿using System;
using System.Data;
using System.Diagnostics;

// <Snippet1>
/* Create a listener, which outputs to the console screen, and
  * add it to the trace listeners. */
TextWriterTraceListener myWriter = new TextWriterTraceListener();
myWriter.Writer = System.Console.Out;
Trace.Listeners.Add(myWriter);

// </Snippet1>
