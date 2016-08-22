﻿/*
 
 * Author:	Bob Limnor (info@limnor.com)
 * Project: Limnor Studio
 * Item:	Visual Object Builder Utility
 * License: GNU General Public License v3.0
 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VPL
{
	public class DlgSetEditorAttributes : Form
	{
		private DataEditor _editor;
		public DlgSetEditorAttributes()
		{
		}
		public DlgSetEditorAttributes(DataEditor editor)
		{
			_editor = editor;
		}
		/// <summary>
		/// use current value to set attributes if needed
		/// </summary>
		/// <param name="current"></param>
		public virtual void SetEditorAttributes(DataEditor current)
		{
		}
		/// <summary>
		/// modify the selection if needed. usually not
		/// </summary>
		/// <param name="selected"></param>
		public void SetSelection(DataEditor selected)
		{
			_editor = selected;
		}
		/// <summary>
		/// the editor selected by the user
		/// </summary>
		public DataEditor SelectedEditor
		{
			get
			{
				return _editor;
			}
		}
	}
}
