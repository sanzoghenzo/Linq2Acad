﻿using System;
using System.Linq;
using Linq2Acad;
using Autodesk.AutoCAD.DatabaseServices;
using AcadTestRunner;

namespace Linq2Acad.Tests
{
  public partial class LayoutContainerTests
  {
    [AcadTest("CreateLayout")]
    public void CreateLayout()
    {
      var newId = ObjectId.Null;

      using (var db = AcadDatabase.Active())
      {
        var newLayout = db.Layouts.Create("NewLayout");
        newId = newLayout.ObjectId;
      }

      AcadAssert.That.LayoutDictionary.Contains("NewLayout");
      AcadAssert.That.LayoutDictionary.Contains(newId);
    }
  }
}