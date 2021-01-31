using MultipleImplementaionTest.Services.Implementation;
using MultipleImplementaionTest.Services.Interface;
using System.Web.Mvc;

namespace MultipleImplementaionTest.Controllers
{
    public class HomeController : Controller
    {
        //IImplementation<IsolatedImplementation> _isolated;
        IImplementation<SmartERPImplementation> _smartERP;
        IImplementation<OracleERPImplementaion> _oracleERP;
        public HomeController(
            //IImplementation<IsolatedImplementation> isolated,
            IImplementation<SmartERPImplementation> smartERP,
            IImplementation<OracleERPImplementaion> oracleERP)
        {
            //_isolated = isolated;
            _smartERP = smartERP;
            _oracleERP = oracleERP;

        }
        public ActionResult Index()
        {
            var isolated= _smartERP.Get(1);
            var oracle = _smartERP.Get(2);
            var smart = _oracleERP.Get(3);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}