// DO NOT EDIT! This is an autogenerated file. All changes will be
// overwritten!

//	Copyright (c) 2023 Vidyo, Inc. All rights reserved.


using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace VidyoClient
{
	public class EndpointShareOptionsFactory
	{
		public static EndpointShareOptions Create()
		{
			return new EndpointShareOptions(IntPtr.Zero);
		}
		public static void Destroy(EndpointShareOptions obj)
		{
		}
	}
	/// <summary>
	/// Represent the options for sharing.
	/// </summary>
	public class EndpointShareOptions {
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoEndpointShareOptions reference.
		public IntPtr GetObjectPtr() {

			VidyoEndpointShareOptionsSetenableAudioNative(objPtr, enableAudio);
			VidyoEndpointShareOptionsSetenableHighFramerateNative(objPtr, enableHighFramerate);

			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoEndpointShareOptionsGetenableAudioNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoEndpointShareOptionsSetenableAudioNative(IntPtr obj, Boolean enableAudio);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoEndpointShareOptionsGetenableHighFramerateNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoEndpointShareOptionsSetenableHighFramerateNative(IntPtr obj, Boolean enableHighFramerate);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoEndpointShareOptionsConstructCopyNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoEndpointShareOptionsConstructDefaultNative();

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoEndpointShareOptionsDestructNative(IntPtr obj);

		/// <summary>
		/// A variable that indicates whether the sharing will be with or without audio.
		/// </summary>
		public Boolean enableAudio;
		/// <summary>
		/// A variable that indicates whether the sharing will be with or without high framerate share.
		/// </summary>
		public Boolean enableHighFramerate;
		public EndpointShareOptions(IntPtr obj){
			if(obj == IntPtr.Zero) {
				objPtr = VidyoEndpointShareOptionsConstructDefaultNative();
			}
			else {
				objPtr = VidyoEndpointShareOptionsConstructCopyNative(obj);
			}

			enableAudio = VidyoEndpointShareOptionsGetenableAudioNative(objPtr);
			enableHighFramerate = VidyoEndpointShareOptionsGetenableHighFramerateNative(objPtr);
		}
		~EndpointShareOptions() {
			VidyoEndpointShareOptionsDestructNative(objPtr);
		 }
	};
}
