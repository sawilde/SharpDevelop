﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Siegfried Pammer" email="sie_pam@gmx.at"/>
//     <version>$Revision$</version>
// </file>

using ICSharpCode.SharpDevelop.Editor.CodeCompletion;
using System;
using ICSharpCode.SharpDevelop.Dom;
using NUnit.Framework;

namespace ICSharpCode.XamlBinding.Tests
{
	public class TextEditorBasedTests
	{
		protected MockTextEditor textEditor;
		
		[SetUp]
		public void SetupTest()
		{
			this.textEditor = new MockTextEditor();
		}
		
		protected void TestCtrlSpace(string fileHeader, string fileFooter, bool expected, Action<ICompletionItemList> constraint)
		{
			this.textEditor.Document.Text = fileHeader + fileFooter;
			this.textEditor.Caret.Offset = fileHeader.Length;
			this.textEditor.CreateParseInformation();
			
			bool invoked = XamlCodeCompletionBinding.Instance.CtrlSpace(textEditor);
			
			Assert.AreEqual(expected, invoked);
			
			ICompletionItemList list = this.textEditor.LastCompletionItemList;
			
			constraint(list);
		}
		
		protected void TestKeyPress(string fileHeader, string fileFooter, char keyPressed, CodeCompletionKeyPressResult keyPressResult, Action<ICompletionItemList> constraint)
		{
			this.textEditor.Document.Text = fileHeader + fileFooter;
			this.textEditor.Caret.Offset = fileHeader.Length;
			this.textEditor.CreateParseInformation();
			
			CodeCompletionKeyPressResult result = XamlCodeCompletionBinding.Instance.HandleKeyPress(textEditor, keyPressed);
			
			Assert.AreEqual(keyPressResult, result);
			
			ICompletionItemList list = this.textEditor.LastCompletionItemList;
			
			constraint(list);
		}
	}
}