﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

namespace osu.Framework.Graphics.Shaders
{
    /// <summary>
    /// Represents all global shader properties.
    /// </summary>
    internal enum GlobalProperty
    {
        ProjMatrix,
        MaskingRect,
        ToMaskingSpace,
        CornerRadius,
        CornerExponent,
        BorderThickness,
        BorderColour,
        MaskingBlendRange,
        AlphaExponent,
        EdgeOffset,
        DiscardInner,
        InnerCornerRadius,
        GammaCorrection,
        WrapModeS,
        WrapModeT,
        BackbufferDraw,
    }
}
