using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASMShareStateBetweenComponents.Services
{
    public interface IShareStateService
    {
        string Data { get; set; }
        event Action OnChange;
    }
}
