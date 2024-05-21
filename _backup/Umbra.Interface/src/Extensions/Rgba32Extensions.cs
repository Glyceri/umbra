/* Umbra.Interface | (c) 2024 by Una    ____ ___        ___.
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

using SixLabors.ImageSharp.PixelFormats;

namespace Umbra.Interface;

public static class Rgba32Extensions
{
    /// <summary>
    /// Returns the color as a Uint32 value.
    /// </summary>
    public static uint ToUint(this Rgba32 color, float alpha = 1f)
    {
        return (uint)(
              (byte)(color.A * alpha) << 24
            | (byte)(color.B * alpha) << 16
            | (byte)(color.G * alpha) << 8
            | (byte)(color.R * alpha)
        );
    }
}
