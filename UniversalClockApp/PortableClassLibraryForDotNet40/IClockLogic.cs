using System;

namespace PortableClassLibraryForDotNet40
{
   public interface IClockLogic
   {
      DateTimeOffset CurrentTime { get;  }

      bool SetTimezon(TimeZoneInfo newTimeZone);
   }
}
