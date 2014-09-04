using System;
using System.Collections.Generic;

namespace Glimpse.SignalR.Hubs.Plumbing.GetHubs
{
    public class HubMethodModel
    {
        public string Name { get; set; }
        public Type ReturnType { get; set; }
        public IEnumerable<HubMethodParameterModel> Parameters { get; set; }
    }
}