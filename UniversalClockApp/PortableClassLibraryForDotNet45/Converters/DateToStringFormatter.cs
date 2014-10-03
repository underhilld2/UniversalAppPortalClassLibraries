using System;

namespace PortableClassLibraryForDotNet45.Converters
{
   public sealed class DateToStringFormatter //: IValueConverter
   {
      public object Convert( object value, Type targetType, object parameter, string language )
      {
         return PortableClassLibraryForDotNet40.Converters.DateToStringFormatter.Convert( value, targetType, parameter, language );
      }

      public object ConvertBack( object value, Type targetType, object parameter, string language )
      {
         throw new NotImplementedException();
      }
   }


}
