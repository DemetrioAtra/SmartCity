using Microsoft.AspNetCore.Mvc.Filters;

namespace DevD.FutureMaterials.Controllers.Filters
{
    public class LogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            System.Diagnostics.Debug.WriteLine("------------------------- LOG -------------------------");
            System.Diagnostics.Debug.WriteLine("Controller " + context.RouteData.Values["Controller"] + " - Action " + context.RouteData.Values["Action"]);
            System.Diagnostics.Debug.WriteLine("Data e hora: " + DateTime.Now);
            System.Diagnostics.Debug.WriteLine("-------------------------------------------------------");
        }
    }
}
