﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ohana3DS_Rebirth.Ohana
{
    class FileIdentifier
    {
        public enum fileFormat
        {
            Unsupported,
            H3D
        }

        public static fileFormat identify(String fileName)
        {
            FileStream data = new FileStream(fileName, FileMode.Open);
            BinaryReader input = new BinaryReader(data);
            String magic = IOUtils.readString(input, 0);
            input.Close();

            switch (magic)
            {
                case "BCH": return fileFormat.H3D;
                default: return fileFormat.Unsupported;
            }
        }
    }
}
