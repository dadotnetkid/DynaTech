using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynaBlazor.Common.Interfaces.Components;
using DynaBlazor.Component;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace DynaBlazor.Common.Services
{
    public class ToastComponentService : IDynToast
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public DynToastContainer container { get; set; }
        public ToastComponentService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }
        public async Task ShowToast(string title, string message)
        {
            await container.ShowToast(title, message);
        }
    }
}
