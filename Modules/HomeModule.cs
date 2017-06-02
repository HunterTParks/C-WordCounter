using Nancy;

namespace CProject.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["sentence"], Request.Form["word"]);
        return View["result.cshtml", newRepeatCounter];
      };
    }
  }
}
