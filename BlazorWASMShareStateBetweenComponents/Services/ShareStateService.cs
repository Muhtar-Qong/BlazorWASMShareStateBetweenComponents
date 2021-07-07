using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASMShareStateBetweenComponents.Services
{
    public class ShareStateService: IShareStateService
    {
        private string stateData = "";
        public string Data
        {
            get => stateData;
            set
            {
                stateData = value;
                NotifyStateChanged();
            }
        }
        public event Action OnChange;
        void NotifyStateChanged() => OnChange?.Invoke();
    }
}
