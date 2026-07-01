using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;

using WpfCctvMonitorApp.Models;

namespace WpfCctvMonitorApp.Serices
{
    public class ItsCctvService
    {
        private readonly HttpClient httpClient = new();

        public async Task<ObservableCollection<Cctvinfo>> GetCctvListAsync()
        {
            return null;
        }

    }
}
