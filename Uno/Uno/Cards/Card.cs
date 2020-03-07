﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Image = System.Windows.Controls.Image;

namespace Uno
{
    [Serializable()]
    class Card
    {
        private string  mImageName;

        public Card()
        {

        }

        public Card (string pImageName)
        {
            this.mImageName = pImageName;
        }

        public string ImageName
        {
            get { return mImageName; }
        }
    }
}