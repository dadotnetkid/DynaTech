using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynaBlazor.Common.Interfaces.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace DynaBlazor.Component
{
    public partial class DynToastContainer 
    {
        [Inject] private IJSRuntime jsRuntime { get; set; }
        [Inject] private IDynToast toastComponent { get; set; }
        public DynToastContainer container { get; set; }
        internal string Message { get; set; }
        internal string Title { get; set; }
        internal string toastId = Guid.NewGuid().ToString();


        public DynToastContainer()
        {
        }
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                toastComponent.container = this;
            }
        }
        public async Task ShowToast(string title, string message)
        {
            Message = message;
            Title = title;
            await jsRuntime.InvokeVoidAsync("ShowToast", toastId);
            StateHasChanged();
        }

      
    }
}
