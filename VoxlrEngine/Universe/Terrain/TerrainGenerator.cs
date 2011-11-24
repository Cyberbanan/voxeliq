﻿/*
 * Copyright (C) 2011 - Hüseyin Uslu shalafiraistlin@gmail.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

namespace VolumetricStudios.VoxlrEngine.Universe.Terrain
{
    public class TerrainGenerator
    {
        public void Generate(Chunk chunk)
        {
            /* The chunk should be in queued state, if not just ignore the generate request */

            if (chunk.Generated) return;

            this.GenerateChunk(chunk);
            chunk.Generated = true;
        }

        protected virtual void GenerateChunk(Chunk chunk) { }
    }
}
