﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedNativeWifi.Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			if (!Debugger.IsAttached)
				Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));

			Debug.WriteLine("[Available Networks]");
			NativeWifi.EnumerateAvailableNetworkSsids().ToArray();

			Debug.WriteLine("[Connected Networks]");
			NativeWifi.EnumerateConnectedNetworkSsids().ToArray();

			Debug.WriteLine("[Network Profiles]");
			NativeWifi.EnumerateProfileNames().ToArray();
			NativeWifi.EnumerateProfiles().ToArray();
		}
	}
}