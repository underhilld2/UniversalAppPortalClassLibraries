using Windows.Storage.Search;

namespace BasicProjectTemplate.Logic
{
    public class MyLogic
    {
       public MyLogic()
       {
          //#if WINDOWS_APP
          var temp = new QueryOptions();
          //#endif
       }
    }
}
