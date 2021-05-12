﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="WildGums">
//   Copyright (c) 2008 - 2018 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Controls.Example.ViewModels
{
    using Catel.MVVM;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            DeferValidationUntilFirstSaveCall = false;
        }

        public override string Title => "Orc.Controls example";
    }
}
