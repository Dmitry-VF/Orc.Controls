﻿namespace Orc.Controls.Controls.StepBar.ViewModels
{
    using Catel.MVVM;
    using Orc.Controls.Controls.StepBar.Models;

    public class AgeWizardPageViewModel
    {
        public AgeWizardPageViewModel()
        {
        }

        [ViewModelToModel]
        public string Age { get; set; }
    }
}
