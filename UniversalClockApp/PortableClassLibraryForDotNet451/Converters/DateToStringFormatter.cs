using System;

namespace PortableClassLibraryForDotNet451.Converters
{
   public sealed class DateToStringFormatter //: IValueConverter
   {
      private DateToStringFormatter _dateFormatter = new DateToStringFormatter();

      public object Convert( object value, Type targetType, object parameter, string language )
      {
         return _dateFormatter.Convert( value, targetType, parameter, language );
      }

      public object ConvertBack( object value, Type targetType, object parameter, string language )
      {
         throw new NotImplementedException();
      }
   }


}
