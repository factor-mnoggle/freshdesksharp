using DBA.FreshdeskSharp.Models.Abstractions;

namespace DBA.FreshdeskSharp.Models.Internal
{
    internal class FreshdeskContactFromListInternal : FreshdeskContactFromListInternalBase<object>
    {
    }

    internal class FreshdeskContactFromListInternal<TCustomFieldObject> : FreshdeskContactFromListInternalBase<TCustomFieldObject> where TCustomFieldObject : class
    {
    }
}
