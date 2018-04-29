using Abp.Web.Mvc.Views;

namespace DJGO.ABPGMEdu.Web.Views
{
    public abstract class ABPGMEduWebViewPageBase : ABPGMEduWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPGMEduWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPGMEduWebViewPageBase()
        {
            LocalizationSourceName = ABPGMEduConsts.LocalizationSourceName;
        }
    }
}