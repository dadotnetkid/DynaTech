using DynaBlazor.Component;

namespace DynaBlazor.Common.Interfaces.Components;

public interface IDynToast
{
    public Task ShowToast(string title, string message);
    public DynToastContainer container { get; set; }
}