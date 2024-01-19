// DO NOT EDIT! This is an autogenerated file. All changes will be
// overwritten!

//	Copyright (c) 2023 Vidyo, Inc. All rights reserved.


namespace VidyoClient
{
	/// <summary>
	/// Types of services available to reference for calendar specific data and events.
	/// </summary>
	public enum CalendarState {
		/// <summary>Indicates that the service is not available in the environmemt due to either an unreachable server, or by lack of an installed product.</summary>
		CalendarstateUnavailable,
		/// <summary>Verified that the service is available to attempt a connection against.</summary>
		CalendarstateInitialized,
		/// <summary></summary>
		CalendarstateConnecting,
		/// <summary></summary>
		CalendarstateConnected,
		/// <summary></summary>
		CalendarstateDisconnecting,
		/// <summary></summary>
		CalendarstateDisconnected
	}
}
