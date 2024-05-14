/* Umbra | (c) 2024 by Una              ____ ___        ___.
 * Licensed under the terms of AGPL-3  |    |   \ _____ \_ |__ _______ _____
 *                                     |    |   //     \ | __ \\_  __ \\__  \
 * https://github.com/una-xiv/umbra    |    |  /|  Y Y  \| \_\ \|  | \/ / __ \_
 *                                     |______//__|_|  /____  /|__|   (____  /
 *     Umbra is free software: you can redistribute  \/     \/             \/
 *     it and/or modify it under the terms of the GNU Affero General Public
 *     License as published by the Free Software Foundation, either version 3
 *     of the License, or (at your option) any later version.
 *
 *     Umbra UI is distributed in the hope that it will be useful,
 *     but WITHOUT ANY WARRANTY; without even the implied warranty of
 *     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *     GNU Affero General Public License for more details.
 */

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Umbra.Markers;

/// <summary>
/// Represents a world marker object.
/// </summary>
/// <remarks>
/// This class represents one or more world markers that are displayed in the
/// game world in a single location.
/// </remarks>
public class WorldMarkerObject
{
    public Vector3 Position = new();

    public List<uint> IconIds = [];

    public List<MarkerText> Text = [];

    public bool ShowDirection = true;

    public float MinOpacity = 0f;

    public float MaxOpacity = 1f;

    public float MinFadeDistance = 1f;

    public float MaxFadeDistance = 100f;

    public Action? OnClick;
}

public struct MarkerText
{
    public string? Label;
    public string? SubLabel;
}
