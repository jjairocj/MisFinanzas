using Abp.Web.Mvc.Views;

namespace MisFinanzas.Web.Views
{
    public abstract class MisFinanzasWebViewPageBase : MisFinanzasWebViewPageBase<dynamic>
    {

    }

    public abstract class MisFinanzasWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MisFinanzasWebViewPageBase()
        {
            LocalizationSourceName = MisFinanzasConsts.LocalizationSourceName;
        }
    }
}