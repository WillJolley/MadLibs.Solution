using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/filledoutml")]
    public ActionResult FilledOutML(string noun1, string noun2, string pluralNoun1, string pluralNoun2, string pluralNoun3, string pluralNoun4, string noun3, string noun4, string pluralNoun5, string adjective1, string verb1, string pluralNoun6, string adjective2, string noun5, string pluralNoun7, string noun6) 
    {
      Words viewModel = new Words();
      viewModel.Noun1 = noun1;
      viewModel.Noun2 = noun2;
      viewModel.PluralNoun1 = pluralNoun1;
      viewModel.PluralNoun2 = pluralNoun2;
      viewModel.PluralNoun3 = pluralNoun3;
      viewModel.PluralNoun4 = pluralNoun4;
      viewModel.Noun3 = noun3;
      viewModel.Noun4 = noun4;
      viewModel.PluralNoun5 = pluralNoun5;
      viewModel.Adjective1 = adjective1;
      viewModel.Verb1 = verb1;
      viewModel.PluralNoun6 = pluralNoun6;
      viewModel.Adjective2 = adjective2;
      viewModel.Noun5 = noun5;
      viewModel.PluralNoun7 = pluralNoun7;
      viewModel.Noun6 = noun6;

      return View(viewModel);
    }



    [Route("/")] 
    public ActionResult Form() 
    { 
      return View(); 
    }
  }
}