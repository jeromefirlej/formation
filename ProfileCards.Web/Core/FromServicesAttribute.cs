namespace ProfileCards.Web.Core
{
    using System;
    using System.Web.Http.ModelBinding;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter)]
    public class FromServicesAttribute : ModelBinderAttribute
    {
        public FromServicesAttribute()
            : base(typeof(FromServicesModelBinder))
        {
        }
    }
}   