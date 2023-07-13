﻿namespace Application.Utils
{
    public class PagedList<T>
    {
        private PagedList(List<T> items, int page, int pageSize, int totalCount)
        {
            this.items = items;
            Page = page;
            PageSize = pageSize;
            TotalCount = totalCount;
        }

        public List<T> items { get; }
        public int Page { get; }
        public int PageSize { get; }
        public int TotalCount { get; }
        public bool HasNextPage => Page * PageSize < TotalCount;
        public bool HasPreviousPage => Page > 1;

        public static PagedList<T> Create(IQueryable<T> query, int page, int pageSize)
        {
            var totalCount = query.Count();
            var items = query.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new(items, page, pageSize, totalCount);
        }
    }
}
