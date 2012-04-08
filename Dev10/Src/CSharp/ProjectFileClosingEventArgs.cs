/***************************************************************************

Copyright (c) Microsoft Corporation. All rights reserved.
This code is licensed under the Visual Studio SDK license terms.
THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

***************************************************************************/

namespace Microsoft.VisualStudio.Project
{
	using System;
	using System.Diagnostics.CodeAnalysis;

	public class ProjectFileClosingEventArgs : EventArgs
	{
		#region fields
		private readonly bool removed;
		#endregion

		#region properties
		/// <summary>
		/// true if the project was removed from the solution before the solution was closed. false if the project was removed from the solution while the solution was being closed.
		/// </summary>
		[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		internal bool Removed
		{
			get { return this.removed; }
		}
		#endregion

		#region ctor
		internal ProjectFileClosingEventArgs(bool removed)
		{
			this.removed = removed;
		}
		#endregion
	}
}