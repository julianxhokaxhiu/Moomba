/***************************************************************************
*    Copyright (C) 2023 Julian Xhokaxhiu                                   *
*                                                                          *
*    This file is part of Moomba                                           *
*                                                                          *
*    Moomba is free software: you can redistribute it and/or modify        *
*    it under the terms of the GNU General Public License as published by  *
*    the Free Software Foundation, either version 3 of the License         *
*                                                                          *
*    Moomba is distributed in the hope that it will be useful,             *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of        *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
*    GNU General Public License for more details.                          *
***************************************************************************/

using System.Runtime.InteropServices;

namespace Moomba.Core
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    struct CamData
    {
		// EYE
		public short eye_x;
		public short eye_y;
		public short eye_z;
		// TARGET
		public short target_x;
		public short target_y;
		public short target_z;
		// UP
		public short up_x;
		public short up_y;
		public short up_z;
		// FILLER?
		public short padding;
		// POSITION
		public int pos_x;
		public int pos_y;
		public int pos_z;
		// PAN
		public short pan_x;
		public short pan_y;
		// ZOOM
		public short zoom;
        public short zoom2;
        // RENDER MODE
        // - 0x08 = render characters over FMV and masks meshes over characters (hiding/masking them)
        // - 0x10 = render characters over FMV (not masked)
        // - 0x11 = don't render characters over FMV
        // - 0x50 = End Transition? (not sure what's this exactly but for sure the character are not rendered with this on)
        // For more info see http://wiki.ffrtt.ru/index.php?title=FF8/FileFormat_PAK
        public char render_mode;
		// END MARKER ( 'E', 'N', 'D' )
        public char marker_e;
        public char marker_n;
        public char marker_d;
    }
}
