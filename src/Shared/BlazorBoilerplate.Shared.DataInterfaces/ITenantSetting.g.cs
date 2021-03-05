//Autogenerated by BlazorBoilerplate.EntityGenerator
using BlazorBoilerplate.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface ITenantSetting
    {
        String TenantId { get; set; }

        SettingKey Key { get; set; }

        String Value { get; set; }

        SettingType Type { get; set; }

    }
}