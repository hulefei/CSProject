using System;
using System.Collections;
using System.Collections.Generic;

namespace CSProject.Chapter06
{
    public class TimeTable : IEnumerable
    {
        public DateTime startData;
        private DateTime EndData { get; set; }

        public TimeTable(DateTime startData, DateTime endData)
        {
            this.startData = startData;
            EndData = endData;
        }

        public IEnumerable<DateTime> DateRange
        {
            get
            {
                for (var day = startData; day <= EndData; day = day.AddDays(1))
                {
                    yield return day;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (var day = startData; day <= EndData; day = day.AddDays(1))
            {
                yield return day;
            }
        }
    }
}