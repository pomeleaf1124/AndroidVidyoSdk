// DO NOT EDIT! This is an autogenerated file. All changes will be
// overwritten!

//	Copyright (c) 2023 Vidyo, Inc. All rights reserved.


using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace VidyoClient
{
	public class LocalVideoSourceStatsFactory
	{
		public static LocalVideoSourceStats Create()
		{
			return new LocalVideoSourceStats(IntPtr.Zero);
		}
		public static void Destroy(LocalVideoSourceStats obj)
		{
		}
	}
	/// <summary>
	/// Statistics for a local video source.
	/// </summary>
	public class LocalVideoSourceStats {
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoLocalVideoSourceStats reference.
		public IntPtr GetObjectPtr() {
			IntPtr nId = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(id ?? string.Empty);
			IntPtr nLocalRendererStreams = Marshal.AllocHGlobal(Marshal.SizeOf<IntPtr>() * localRendererStreams.Count);
			int nLocalRendererStreamsSize = 0;
			IntPtr nName = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(name ?? string.Empty);
			IntPtr nRemoteRendererStreams = Marshal.AllocHGlobal(Marshal.SizeOf<IntPtr>() * remoteRendererStreams.Count);
			int nRemoteRendererStreamsSize = 0;

			foreach (LocalRendererStreamStats iter in localRendererStreams) {
				Marshal.WriteIntPtr(nLocalRendererStreams + (nLocalRendererStreamsSize * Marshal.SizeOf<IntPtr>()), iter.GetObjectPtr());
				nLocalRendererStreamsSize++;
			}
			foreach (RemoteRendererStreamStats iter in remoteRendererStreams) {
				Marshal.WriteIntPtr(nRemoteRendererStreams + (nRemoteRendererStreamsSize * Marshal.SizeOf<IntPtr>()), iter.GetObjectPtr());
				nRemoteRendererStreamsSize++;
			}

			VidyoLocalVideoSourceStatsSetcameraEffectNative(objPtr, cameraEffect.GetObjectPtr());
			VidyoLocalVideoSourceStatsSetformatNative(objPtr, format);
			VidyoLocalVideoSourceStatsSetframeIntervalMeasuredNative(objPtr, frameIntervalMeasured);
			VidyoLocalVideoSourceStatsSetframeIntervalSetNative(objPtr, frameIntervalSet);
			VidyoLocalVideoSourceStatsSetheightNative(objPtr, height);
			VidyoLocalVideoSourceStatsSetidNative(objPtr, nId);
			VidyoLocalVideoSourceStatsSetlocalRendererStreamsNative(objPtr, nLocalRendererStreams, nLocalRendererStreamsSize);
			VidyoLocalVideoSourceStatsSetnameNative(objPtr, nName);
			VidyoLocalVideoSourceStatsSetremoteRendererStreamsNative(objPtr, nRemoteRendererStreams, nRemoteRendererStreamsSize);
			VidyoLocalVideoSourceStatsSettargetBitRateNative(objPtr, targetBitRate);
			VidyoLocalVideoSourceStatsSettotalFramesNative(objPtr, totalFrames);
			VidyoLocalVideoSourceStatsSetwidthNative(objPtr, width);

			Marshal.FreeHGlobal(nRemoteRendererStreams);
			Marshal.FreeHGlobal(nName);
			Marshal.FreeHGlobal(nLocalRendererStreams);
			Marshal.FreeHGlobal(nId);
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalVideoSourceStatsGetcameraEffectNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetcameraEffectNative(IntPtr obj, IntPtr cameraEffect);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern MediaFormat VidyoLocalVideoSourceStatsGetformatNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetformatNative(IntPtr obj, MediaFormat format);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalVideoSourceStatsGetframeIntervalMeasuredNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetframeIntervalMeasuredNative(IntPtr obj, ulong frameIntervalMeasured);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalVideoSourceStatsGetframeIntervalSetNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetframeIntervalSetNative(IntPtr obj, ulong frameIntervalSet);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(SizeTMarshaler))]
		private static extern SizeT VidyoLocalVideoSourceStatsGetheightNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetheightNative(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(SizeTMarshaler))]SizeT height);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalVideoSourceStatsGetidNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetidNative(IntPtr obj, IntPtr id);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalVideoSourceStatsGetlocalRendererStreamsNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetlocalRendererStreamsNative(IntPtr obj, IntPtr localRendererStreams, int size);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalVideoSourceStatsGetlocalRendererStreamsArrayNative(IntPtr obj, ref int size);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsFreelocalRendererStreamsArrayNative(IntPtr obj, int size);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalVideoSourceStatsGetnameNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetnameNative(IntPtr obj, IntPtr name);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalVideoSourceStatsGetremoteRendererStreamsNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetremoteRendererStreamsNative(IntPtr obj, IntPtr remoteRendererStreams, int size);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalVideoSourceStatsGetremoteRendererStreamsArrayNative(IntPtr obj, ref int size);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsFreeremoteRendererStreamsArrayNative(IntPtr obj, int size);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLocalVideoSourceStatsGettargetBitRateNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSettargetBitRateNative(IntPtr obj, ulong targetBitRate);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoLocalVideoSourceStatsGettotalFramesNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSettotalFramesNative(IntPtr obj, uint totalFrames);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(SizeTMarshaler))]
		private static extern SizeT VidyoLocalVideoSourceStatsGetwidthNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalVideoSourceStatsSetwidthNative(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(SizeTMarshaler))]SizeT width);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoLocalVideoSourceStatsConstructCopyNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoLocalVideoSourceStatsConstructDefaultNative();

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoLocalVideoSourceStatsDestructNative(IntPtr obj);

		/// <summary>
		/// Camera effect statistics.
		/// </summary>
		public CameraEffectStats cameraEffect;
		/// <summary>
		/// Format.
		/// </summary>
		public MediaFormat format;
		/// <summary>
		/// Frame interval measured between last 2 frames.
		/// </summary>
		public ulong frameIntervalMeasured;
		/// <summary>
		/// Frame interval setting.
		/// </summary>
		public ulong frameIntervalSet;
		/// <summary>
		/// Height.
		/// </summary>
		public SizeT height;
		/// <summary>
		/// Id.
		/// </summary>
		public String id;
		/// <summary>
		/// Vector of stats of local renderer streams.
		/// </summary>
		public List<LocalRendererStreamStats> localRendererStreams;
		/// <summary>
		/// Name.
		/// </summary>
		public String name;
		/// <summary>
		/// Vector of stats of remote renderer streams.
		/// </summary>
		public List<RemoteRendererStreamStats> remoteRendererStreams;
		/// <summary>
		/// Target bit rate.
		/// </summary>
		public ulong targetBitRate;
		/// <summary>
		/// Total frames.
		/// </summary>
		public uint totalFrames;
		/// <summary>
		/// Width.
		/// </summary>
		public SizeT width;
		public LocalVideoSourceStats(IntPtr obj){
			if(obj == IntPtr.Zero) {
				objPtr = VidyoLocalVideoSourceStatsConstructDefaultNative();
			}
			else {
				objPtr = VidyoLocalVideoSourceStatsConstructCopyNative(obj);
			}

			CameraEffectStats csCameraEffect = new CameraEffectStats(VidyoLocalVideoSourceStatsGetcameraEffectNative(objPtr));
			List<LocalRendererStreamStats> csLocalRendererStreams = new List<LocalRendererStreamStats>();
			var nLocalRendererStreamsSize = 0;
			var nLocalRendererStreams = VidyoLocalVideoSourceStatsGetlocalRendererStreamsArrayNative(VidyoLocalVideoSourceStatsGetlocalRendererStreamsNative(objPtr), ref nLocalRendererStreamsSize);
			var nLocalRendererStreamsIndex = 0;
			while (nLocalRendererStreamsIndex < nLocalRendererStreamsSize) {
				LocalRendererStreamStats csTlocalRendererStreams = new LocalRendererStreamStats(Marshal.ReadIntPtr(nLocalRendererStreams + (nLocalRendererStreamsIndex * Marshal.SizeOf(nLocalRendererStreams))));
				csLocalRendererStreams.Add(csTlocalRendererStreams);
				nLocalRendererStreamsIndex++;
			}

			List<RemoteRendererStreamStats> csRemoteRendererStreams = new List<RemoteRendererStreamStats>();
			var nRemoteRendererStreamsSize = 0;
			var nRemoteRendererStreams = VidyoLocalVideoSourceStatsGetremoteRendererStreamsArrayNative(VidyoLocalVideoSourceStatsGetremoteRendererStreamsNative(objPtr), ref nRemoteRendererStreamsSize);
			var nRemoteRendererStreamsIndex = 0;
			while (nRemoteRendererStreamsIndex < nRemoteRendererStreamsSize) {
				RemoteRendererStreamStats csTremoteRendererStreams = new RemoteRendererStreamStats(Marshal.ReadIntPtr(nRemoteRendererStreams + (nRemoteRendererStreamsIndex * Marshal.SizeOf(nRemoteRendererStreams))));
				csRemoteRendererStreams.Add(csTremoteRendererStreams);
				nRemoteRendererStreamsIndex++;
			}

			cameraEffect = csCameraEffect;
			format = VidyoLocalVideoSourceStatsGetformatNative(objPtr);
			frameIntervalMeasured = VidyoLocalVideoSourceStatsGetframeIntervalMeasuredNative(objPtr);
			frameIntervalSet = VidyoLocalVideoSourceStatsGetframeIntervalSetNative(objPtr);
			height = VidyoLocalVideoSourceStatsGetheightNative(objPtr);
			id = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoLocalVideoSourceStatsGetidNative(objPtr));
			localRendererStreams = csLocalRendererStreams;
			name = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoLocalVideoSourceStatsGetnameNative(objPtr));
			remoteRendererStreams = csRemoteRendererStreams;
			targetBitRate = VidyoLocalVideoSourceStatsGettargetBitRateNative(objPtr);
			totalFrames = VidyoLocalVideoSourceStatsGettotalFramesNative(objPtr);
			width = VidyoLocalVideoSourceStatsGetwidthNative(objPtr);
			VidyoLocalVideoSourceStatsFreeremoteRendererStreamsArrayNative(nRemoteRendererStreams, nRemoteRendererStreamsSize);
			VidyoLocalVideoSourceStatsFreelocalRendererStreamsArrayNative(nLocalRendererStreams, nLocalRendererStreamsSize);
		}
		~LocalVideoSourceStats() {
			VidyoLocalVideoSourceStatsDestructNative(objPtr);
		 }
	};
}
