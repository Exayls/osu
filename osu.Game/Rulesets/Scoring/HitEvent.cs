// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using JetBrains.Annotations;
using osu.Game.Rulesets.Objects;
using osuTK;

namespace osu.Game.Rulesets.Scoring
{
    /// <summary>
    /// A <see cref="HitEvent"/> generated by the <see cref="ScoreProcessor"/> containing extra statistics around a <see cref="HitResult"/>.
    /// </summary>
    public readonly struct HitEvent
    {
        /// <summary>
        /// The time offset from the end of <see cref="HitObject"/> at which the event occurred.
        /// </summary>
        public readonly double TimeOffset;

        /// <summary>
        /// The hit result.
        /// </summary>
        public readonly HitResult Result;

        /// <summary>
        /// The <see cref="HitObject"/> on which the result occurred.
        /// </summary>
        public readonly HitObject HitObject;

        /// <summary>
        /// The <see cref="HitObject"/> occurring prior to <see cref="HitObject"/>.
        /// </summary>
        [CanBeNull]
        public readonly HitObject LastHitObject;

        /// <summary>
        /// A position, if available, at the time of the event.
        /// </summary>
        [CanBeNull]
        public readonly Vector2? Position;

        /// <summary>
        /// Creates a new <see cref="HitEvent"/>.
        /// </summary>
        /// <param name="timeOffset">The time offset from the end of <paramref name="hitObject"/> at which the event occurs.</param>
        /// <param name="result">The <see cref="HitResult"/>.</param>
        /// <param name="hitObject">The <see cref="HitObject"/> that triggered the event.</param>
        /// <param name="lastHitObject">The previous <see cref="HitObject"/>.</param>
        /// <param name="position">A position corresponding to the event.</param>
        public HitEvent(double timeOffset, HitResult result, HitObject hitObject, [CanBeNull] HitObject lastHitObject, [CanBeNull] Vector2? position)
        {
            TimeOffset = timeOffset;
            Result = result;
            HitObject = hitObject;
            LastHitObject = lastHitObject;
            Position = position;
        }

        /// <summary>
        /// Creates a new <see cref="HitEvent"/> with an optional positional offset.
        /// </summary>
        /// <param name="positionOffset">The positional offset.</param>
        /// <returns>The new <see cref="HitEvent"/>.</returns>
        public HitEvent With(Vector2? positionOffset) => new HitEvent(TimeOffset, Result, HitObject, LastHitObject, positionOffset);
    }
}
