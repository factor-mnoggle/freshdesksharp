using System;
using System.Collections.Generic;
using System.Text;

namespace DBA.FreshdeskSharp.Models
{
    public class FreshdeskContactSearchResults : FreshdeskSearchResults<FreshdeskContact<FreshdeskCustomFields>>
    {
    }

    public class FreshdeskContactSearchResults<TCustomFieldObject> : FreshdeskSearchResults<FreshdeskContact<TCustomFieldObject>> where TCustomFieldObject : class
    {
    }
}
