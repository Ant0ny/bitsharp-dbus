// EngineSettings.cs
//
// Copyright (c) 2008 Alan McGovern (alan.mcgovern@gmail.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//

using System;
using NDesk.DBus;
using MonoTorrent.Client;

namespace MonoTorrent.DBus
{
	internal class EngineSettingsAdapter : IEngineSettings
	{
		private ObjectPath path;
		private MonoTorrent.Client.EngineSettings settings;
		
		internal MonoTorrent.Client.EngineSettings Settings
		{
			get { return settings; }
		}
		
		public ObjectPath Path
		{
			get { return path; }
		}
		
		public EngineSettingsAdapter (EngineSettings settings, ObjectPath path)
		{
			this.path = path;
			this.settings = settings;
		}
		
		//public bool AllowLegacyConnections {
		//	get { return settings.AllowLegacyConnections; }
		//	set { settings.AllowLegacyConnections = value;}
		//}

		public bool HaveSupressionEnabled {
			get { return settings.HaveSupressionEnabled; }
			set { settings.HaveSupressionEnabled = value; }
		}

		public int GlobalMaxConnections {
			get { return settings.GlobalMaxConnections; }
			set { settings.GlobalMaxConnections = value; }
		}

		public int GlobalMaxHalfOpenConnections {
			get { return settings.GlobalMaxHalfOpenConnections; }
			set { settings.GlobalMaxHalfOpenConnections = value; }
		}

		public int GlobalMaxDownloadSpeed {
			get { return settings.GlobalMaxDownloadSpeed; }
			set { settings.GlobalMaxDownloadSpeed = value; }
		}

		public int GlobalMaxUploadSpeed {
			get { return settings.GlobalMaxUploadSpeed;}
			set { settings.GlobalMaxUploadSpeed = value; }
		}

		public int ListenPort {
			get { return settings.ListenPort; }
			set { settings.ListenPort = value; }
		}

		public int MaxOpenFiles {
			get { return settings.MaxOpenFiles; }
			set { settings.MaxOpenFiles = value; }
		}

		public int MaxReadRate {
			get { return settings.MaxReadRate; }
			set { settings.MaxReadRate = value; }
		}

		public int MaxWriteRate {
			get { return settings.MaxWriteRate; }
			set { settings.MaxWriteRate = value; }
		}

//		public MonoTorrent.Client.Encryption.EncryptionTypes AllowedEncryption {
//			get { return 0; }
//			set { retu}
//		}

		public string SavePath {
			get { return settings.SavePath; }
			set { settings.SavePath = value; }
		}
	}
}
