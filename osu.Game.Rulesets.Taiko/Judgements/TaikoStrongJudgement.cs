﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Taiko.Judgements
{
    public class TaikoStrongJudgement : TaikoJudgement
    {
        public override HitResult MaxResult => HitResult.SmallBonus;

        // MainObject already changes the HP
        protected override double HealthIncreaseFor(HitResult result) => 0;
    }
}
