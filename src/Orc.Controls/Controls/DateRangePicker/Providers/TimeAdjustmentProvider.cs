﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeAdjustmentProvider.cs" company="WildGums">
//   Copyright (c) 2008 - 2018 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Controls
{
    using System;
    using System.Collections.Generic;

    public class TimeAdjustmentProvider : ITimeAdjustmentProvider
    {
        #region Fields
        private readonly Dictionary<TimeAdjustmentStrategy, TimeAdjustment> _timeAdjustments = new Dictionary<TimeAdjustmentStrategy, TimeAdjustment>();
        #endregion

        #region ITimeAdjustmentProvider Members
        public TimeAdjustment GetTimeAdjustment(TimeAdjustmentStrategy strategy)
        {
            if (_timeAdjustments.TryGetValue(strategy, out var timeAdjustment))
            {
                return timeAdjustment;
            }

            timeAdjustment = CreateTimeAdjustment(strategy);
            _timeAdjustments[strategy] = timeAdjustment;

            return timeAdjustment;
        }
        #endregion

        #region Methods
        private TimeAdjustment CreateTimeAdjustment(TimeAdjustmentStrategy strategy)
        {
            var timeAdjustment = new TimeAdjustment
            {
                Name = GetStrategyName(strategy),
                Strategy = strategy
            };

            return timeAdjustment;
        }

        private string GetStrategyName(TimeAdjustmentStrategy strategy)
        {
            switch (strategy)
            {
                case TimeAdjustmentStrategy.AdjustEndTime:
                    return "Adjust end time";

                case TimeAdjustmentStrategy.AdjustDuration:
                    return "Adjust duration";

                default:
                    throw new ArgumentOutOfRangeException(nameof(strategy), strategy, null);
            }
        }
        #endregion
    }
}
