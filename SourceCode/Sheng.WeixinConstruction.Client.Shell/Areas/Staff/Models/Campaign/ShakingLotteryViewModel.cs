﻿using Sheng.WeixinConstruction.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sheng.WeixinConstruction.Client.Shell.Areas.Staff.Models
{
    public class ShakingLotteryViewModel
    {
        public Campaign_ShakingLotteryBundle CampaignBundle
        {
            get;
            set;
        }

        public Campaign_ShakingLotteryPeriodEntity CurrentPeriod
        {
            get;
            set;
        }

        public List<Campaign_ShakingLotteryPeriodEntity> PeriodList
        {
            get;
            set;
        }
    }
}