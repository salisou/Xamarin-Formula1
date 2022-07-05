﻿using System.Collections.Generic;

namespace Formula1.Models
{
    public class ScheduleModel
    {
        public List<RaceEventModel> UpcomingRaceEvents { get; set; }
        public List<RaceEventModel> PastRaceEvents { get; set; }
    }
}
