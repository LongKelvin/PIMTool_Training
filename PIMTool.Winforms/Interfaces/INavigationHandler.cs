﻿namespace PIMTool.Winforms.Interfaces
{
    public interface INavigationHandler
    {
        void NavigateTo(string userControlName, object[]? data = null);
    }
}