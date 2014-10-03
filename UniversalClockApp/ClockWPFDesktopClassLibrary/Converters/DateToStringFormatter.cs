﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace ClockWPFDesktopClassLibrary.Converters
{
   public sealed class DateToStringFormatter : IValueConverter
   {

      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         return PortableClassLibraryForDotNet40.Converters.DateToStringFormatter.Convert( value, targetType, parameter, culture.ToString() );
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }


}
