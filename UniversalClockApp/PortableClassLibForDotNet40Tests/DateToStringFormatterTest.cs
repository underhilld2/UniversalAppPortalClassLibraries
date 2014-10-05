using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortableClassLibraryForDotNet40.Converters;
using Should;

namespace PortableClassLibForDotNet40Tests
{
   [TestClass]
   public class DateToStringFormatterTest
   {
      private DateToStringFormatter _dateFormatter = new DateToStringFormatter();

      [TestMethod]
      public void TestMethod1()
      {
         var expectedOutput = "09";

         var outputString = string.Empty;
         var testDate = new DateTime(2014,10,12,9,59,23);

         outputString = (string)_dateFormatter.Convert( testDate, null, "hour", null );

         outputString.Trim().ShouldEqual( expectedOutput );
      }
   }
}
