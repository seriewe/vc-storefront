﻿using System.Collections.Specialized;
using VirtoCommerce.Storefront.Model.Common;

namespace VirtoCommerce.Storefront.Model.StaticContent
{
    public class BlogSearchCriteria : PagedSearchCriteria
    {
        public static int DefaultPageSize { get; set; }

        public BlogSearchCriteria()
            : this(new NameValueCollection())
        {
        }

        public BlogSearchCriteria(NameValueCollection queryString)
            : base(queryString, DefaultPageSize)
        {
        }

        public string Category { get; set; }
        public string Tag { get; set; }
        public string Author { get; set; }

        protected virtual void Parse(NameValueCollection queryString)
        {
            Category = queryString.Get("category");
            Tag = queryString.Get("tag");
            Author = queryString.Get("author");
        }
    }
}
