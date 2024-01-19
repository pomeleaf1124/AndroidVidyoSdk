// DO NOT EDIT! This is an autogenerated file. All changes will be
// overwritten!

//	Copyright (c) 2023 Vidyo, Inc. All rights reserved.


using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace VidyoClient
{
	/// <summary>
	/// This object represents a speaker on the local endpoint.
	/// </summary>
	public class LocalSpeaker: IDisposable {
		private bool disposed = false; 
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoLocalSpeaker reference.
		private GCHandle objHandle; // weak VidyoLocalSpeaker reference.
		public IntPtr GetObjectPtr() {
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalSpeakerConstructCopyNative(IntPtr other);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalSpeakerDestructNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoLocalSpeakerDisableDebugRecordingsNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoLocalSpeakerEnableDebugRecordingsNative(IntPtr s, IntPtr dir);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalSpeakerGetIdNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalSpeakerGetNameNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern LocalSpeakerStreamType VidyoLocalSpeakerGetStreamTypeNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalSpeakerGetTypeNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoLocalSpeakerGetVolumeNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoLocalSpeakerIsPausedNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalSpeakerPauseNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoLocalSpeakerPlaySoundNative(IntPtr s, IntPtr sound, Boolean loop);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalSpeakerPlayToneNative(IntPtr s, char dtmfTone);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalSpeakerResumeNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I1)]
		private static extern Boolean VidyoLocalSpeakerSetStreamTypeNative(IntPtr s, [MarshalAs(UnmanagedType.I4)]LocalSpeakerStreamType streamType);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalSpeakerSetVolumeNative(IntPtr s, uint volumePercent);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalSpeakerStopSoundNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoLocalSpeakerGetUserDataNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoLocalSpeakerSetUserDataNative(IntPtr obj, IntPtr userData);

		/// <summary>
		/// The type of the speaker stream. Will determine the speaker audio volume control and default route policy. Supporten on Android only.
		/// </summary>
		public enum LocalSpeakerStreamType {
			/// <summary>Used to identify the volume of audio streams for phone calls.</summary>
			LocalspeakerstreamtypeVoice,
			/// <summary>Used to identify the volume of audio streams for system sounds.</summary>
			LocalspeakerstreamtypeSystem,
			/// <summary>Used to identify the volume of audio streams for the phone ring.</summary>
			LocalspeakerstreamtypeRing,
			/// <summary>Used to identify the volume of audio streams for music playback.</summary>
			LocalspeakerstreamtypeMedia,
			/// <summary>Used to identify the volume of audio streams for alarms.</summary>
			LocalspeakerstreamtypeAlarm,
			/// <summary>Used to identify the volume of audio streams for notifications.</summary>
			LocalspeakerstreamtypeNotification
		}
		public LocalSpeaker(IntPtr other){
			objPtr = VidyoLocalSpeakerConstructCopyNative(other);
			objHandle = GCHandle.Alloc(this, GCHandleType.Weak);
			VidyoLocalSpeakerSetUserDataNative(objPtr, GCHandle.ToIntPtr(objHandle));
		}
		~LocalSpeaker(){
			Dispose(false);
		}
		public void Dispose(){
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public void Dispose(bool disposing){
			if(disposed) return;

			disposed = true;
			if(objPtr != IntPtr.Zero) {
				VidyoLocalSpeakerSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoLocalSpeakerDestructNative(objPtr);
				objPtr = IntPtr.Zero;
			}

			if(objHandle.IsAllocated) objHandle.Free();
		}

		/// <summary>
		/// Disables recording of speaker output to the files.
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public Boolean DisableDebugRecordings() {

			Boolean ret = VidyoLocalSpeakerDisableDebugRecordingsNative(objPtr);

			return ret;
		}
		/// <summary>
		/// Enables recording of speaker output to the files at the specified location.
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		/// <param name="dir">The directory where recordings will be stored.</param>
		public Boolean EnableDebugRecordings(String dir) {

			IntPtr nDir = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(dir ?? string.Empty);
			Boolean ret = VidyoLocalSpeakerEnableDebugRecordingsNative(objPtr, nDir);
			Marshal.FreeHGlobal(nDir);

			return ret;
		}
		/// <summary>
		/// Gets the unique ID of the speaker.
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public String GetId() {

			IntPtr ret = VidyoLocalSpeakerGetIdNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		/// <summary>
		/// Gets the name of the speaker.
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public String GetName() {

			IntPtr ret = VidyoLocalSpeakerGetNameNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		/// <summary>
		/// Gets the current speaker stream type. Supported on Android only.
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public LocalSpeakerStreamType GetStreamType() {

			LocalSpeakerStreamType ret = VidyoLocalSpeakerGetStreamTypeNative(objPtr);

			return ret;
		}
		/// <summary>
		/// Gets the type of the speaker.
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public String GetType() {

			IntPtr ret = VidyoLocalSpeakerGetTypeNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public uint GetVolume() {

			uint ret = VidyoLocalSpeakerGetVolumeNative(objPtr);

			return ret;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public Boolean IsPaused() {

			Boolean ret = VidyoLocalSpeakerIsPausedNative(objPtr);

			return ret;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public void Pause() {

			VidyoLocalSpeakerPauseNative(objPtr);
		}
		/// <summary>
		/// Plays the provided audio frame on the local speaker.
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		/// <param name="sound">The VidyoAudioFrame object to be played.</param>
		/// <param name="loop">Determine whether the audio frame should be repeatedly played.</param>
		public Boolean PlaySound(AudioFrame sound, Boolean loop) {

			Boolean ret = VidyoLocalSpeakerPlaySoundNative(objPtr, (sound != null) ? sound.GetObjectPtr():IntPtr.Zero, loop);

			return ret;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		/// <param name="dtmfTone"></param>
		public void PlayTone(char dtmfTone) {

			VidyoLocalSpeakerPlayToneNative(objPtr, dtmfTone);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public void Resume() {

			VidyoLocalSpeakerResumeNative(objPtr);
		}
		/// <summary>
		/// Sets the current speaker stream type for the device.
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		/// <param name="streamType">Speaker stream type to be set.</param>
		public Boolean SetStreamType(LocalSpeakerStreamType streamType) {

			Boolean ret = VidyoLocalSpeakerSetStreamTypeNative(objPtr, streamType);

			return ret;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		/// <param name="volumePercent">The volume percent to be set. (0 for silence 500 for loudest.)</param>
		public void SetVolume(uint volumePercent) {

			VidyoLocalSpeakerSetVolumeNative(objPtr, volumePercent);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">The VidyoLocalSpeaker object.</param>
		public void StopSound() {

			VidyoLocalSpeakerStopSoundNative(objPtr);
		}
	};
}
