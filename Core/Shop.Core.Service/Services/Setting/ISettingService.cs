﻿using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Setting
{
    public interface ISettingService
    {
        SettingDto GetSetting();
    }
}
