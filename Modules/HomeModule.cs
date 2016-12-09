using Nancy;
using WordCounter2.Objects;
using System;

namespace WordCounter2
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/wordcount"] = _ =>
      {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["user-word"], Request.Form["user-string"]);

        newRepeatCounter.CountRepeats();

        return View["word-count.cshtml", newRepeatCounter];
      };
    }
  }
}
