﻿using Formula1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Formula1.Services.Ergast
{
    public interface IErgastService
    {
        Task<List<DriverStadingsModel>> GetDriverStadings(string year);
        Task<List<ConstructorStadingsModel>> GetTeamStadings(string year);
        Task<List<ScheduleModel>> GetSchedule(string year);
    }
}
