using Abp.Web.Mvc.Views;

namespace FacturaApp.Web.Views
{
    public abstract class FacturaAppWebViewPageBase : FacturaAppWebViewPageBase<dynamic>
    {

    }

    public abstract class FacturaAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected FacturaAppWebViewPageBase()
        {
            LocalizationSourceName = FacturaAppConsts.LocalizationSourceName;
        }
    }
}