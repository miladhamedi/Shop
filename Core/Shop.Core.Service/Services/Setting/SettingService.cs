using AutoMapper;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Setting
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository settingRepository;
        private readonly IMapper mapper;

        public SettingService(ISettingRepository settingRepository,IMapper mapper)
        {
            this.settingRepository = settingRepository;
            this.mapper = mapper;
        }
        public SettingDto GetSetting()
        {
            var Setting = settingRepository.GetSetting();
            var setting = mapper.Map<SettingDto>(Setting);
            return setting;
        }
    }
}
