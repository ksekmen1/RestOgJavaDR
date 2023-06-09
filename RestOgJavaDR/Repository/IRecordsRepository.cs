﻿using RestOgJavaDR.Models;

namespace RestOgJavaDR.Repository
{
    public interface IRecordsRepository
    {
        List<Records> GetAll(string? namefilter = null, string ? artist = null, string? _sortBy = null);
    }
}