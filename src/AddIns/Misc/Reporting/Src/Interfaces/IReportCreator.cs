﻿/*
 * Created by SharpDevelop.
 * User: Peter Forstmeier
 * Date: 21.03.2013
 * Time: 20:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ICSharpCode.Reporting.Interfaces
{
	/// <summary>
	/// Description of IReportCreator.
	/// </summary>
	public interface IReportCreator
	{
		void BuildExportList ();
//		PagesCollection Pages{get;}
//		event EventHandler<PageCreatedEventArgs> PageCreated;
//		event EventHandler<SectionRenderEventArgs> SectionRendering;
//		event EventHandler<GroupHeaderEventArgs> GroupHeaderRendering;
//		event EventHandler<GroupFooterEventArgs> GroupFooterRendering;
//		event EventHandler<RowRenderEventArgs> RowRendering;
	}
}