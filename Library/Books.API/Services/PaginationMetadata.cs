﻿namespace Books.API.Services
{
    public class PaginationMetadata
    {
        public int CurrentPage { get; set; }
        public int TotalItemCount { get; set; }
        public int PageSize { get; set; }
        
        public int TotalPageCount { get; set; }

        
        public PaginationMetadata(int totalItemCount, int pageSize, int currentPage) 
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
        }
    }
}
