using Local_EPiServer.Models.ViewModels;

namespace Local_EPiServer.Business
{
    /// <summary>
    /// Defines a method which may be invoked by PageContextActionFilter allowing controllers
    /// to modify common layout properties of the view model.
    /// </summary>
    interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}
