﻿namespace ApplicationResults.Shared
{
    using Applications.Shared.Enums;
    using CommonLibrary;
    using CommonLibrary.Server;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ApplicationResultViewModel : BaseViewModel
    {
        public ApplicationStatus ApplicationStatus { get; set; }
    }
}
