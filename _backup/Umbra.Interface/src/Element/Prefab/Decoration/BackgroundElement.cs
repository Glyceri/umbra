﻿/* Umbra.Interface | (c) 2024 by Una    ____ ___        ___.
 * Licensed under the terms of AGPL-3  |    |   \ _____ \_ |__ _______ _____
 *                                     |    |   //     \ | __ \\_  __ \\__  \
 * https://github.com/una-xiv/umbra    |    |  /|  Y Y  \| \_\ \|  | \/ / __ \_
 *                                     |______//__|_|  /____  /|__|   (____  /
 *     Umbra.Interface is free software: you can    \/     \/             \/
 *     redistribute it and/or modify it under the terms of the GNU Affero
 *     General Public License as published by the Free Software Foundation,
 *     either version 3 of the License, or (at your option) any later version.
 *
 *     Umbra.Interface is distributed in the hope that it will be useful,
 *     but WITHOUT ANY WARRANTY; without even the implied warranty of
 *     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *     GNU Affero General Public License for more details.
 */

namespace Umbra.Interface;

public class BackgroundElement : Element
{
    public Color          Color;
    public Color          EdgeColor;
    public int            EdgeThickness;
    public float          Opacity;
    public int            Rounding;
    public RoundedCorners Corners;

    public BackgroundElement(
        string         id            = "",
        Color?         color         = null,
        int            edgeThickness = 1,
        Color?         edgeColor     = null,
        float          opacity       = 1,
        int            rounding      = 0,
        RoundedCorners corners       = RoundedCorners.All,
        Spacing        padding       = new()
    ) : base(
        id,
        padding: padding
    )
    {
        Color         = color     ?? new();
        EdgeColor     = edgeColor ?? new();
        EdgeThickness = edgeThickness;
        Opacity       = opacity;
        Rounding      = rounding;
        Corners       = corners;
        Anchor        = Anchor.None;
    }

    protected override void BeforeCompute()
    {
        Style.BackgroundColor       = Color;
        Style.BackgroundBorderColor = EdgeColor;
        Style.BackgroundBorderWidth = EdgeThickness;
        Style.Opacity               = Opacity;
        Style.BackgroundRounding    = Rounding;
        Style.RoundedCorners        = Corners;
    }
}
