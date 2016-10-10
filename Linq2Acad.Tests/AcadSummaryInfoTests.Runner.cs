﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Linq2Acad.Tests
{
  public partial class AcadSummaryInfoTests
  {
    [TestClass]
    [DebuggerStepThrough]
    public partial class BlockContainerTests
    {
      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetCustomProperties()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetCustomProperties");
        if (!result.Passed) Assert.Fail(result.Message);
      }

      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetAuthor()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetAuthor");
        if (!result.Passed) Assert.Fail(result.Message);
      }

      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetComments()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetComments");
        if (!result.Passed) Assert.Fail(result.Message);
      }

      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetHyperlinkBase()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetHyperlinkBase");
        if (!result.Passed) Assert.Fail(result.Message);
      }

      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetKeywords()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetKeywords");
        if (!result.Passed) Assert.Fail(result.Message);
      }

      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetLastSavedBy()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetLastSavedBy");
        if (!result.Passed) Assert.Fail(result.Message);
      }

      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetRevisionNumber()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetRevisionNumber");
        if (!result.Passed) Assert.Fail(result.Message);
      }

      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetSubject()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetSubject");
        if (!result.Passed) Assert.Fail(result.Message);
      }

      [TestMethod]
      [TestCategory("AcadTest")]
      public void TestSetTitle()
      {
        var result = AcadTestRunner.TestRunner.RunTest<AcadSummaryInfoTests>("SetTitle");
        if (!result.Passed) Assert.Fail(result.Message);
      }
    }
  }
}