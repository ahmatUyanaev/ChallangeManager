using ChallengeManager.BizRules.Contracts;
using ChallengeManager.Data.BaseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.Web.Controllers
{
    public class ObjectiveController : Controller
    {

        private readonly IObjectiveBizRules _objectiveBizRules;

        public ObjectiveController(IObjectiveBizRules objectiveBizRules)
        {
            _objectiveBizRules = objectiveBizRules;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> CreateObjective(Objective objective)
        {
            await _objectiveBizRules.AddObjectiveAsync(objective);
            return View();
        }

        public async Task<ActionResult> ObjectiveList()
        {
            return View(await _objectiveBizRules.GetAllObjectivesAsync());
        }
    }
}
