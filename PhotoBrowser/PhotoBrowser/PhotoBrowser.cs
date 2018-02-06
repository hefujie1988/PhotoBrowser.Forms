﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stormlion.PhotoBrowser
{
    public class PhotoBrowser
    {
        public List<Photo> Photos { get; set; }

        public Action<int> ActionButtonPressed { get; set; }

        public ImageSource ActionIcon { get; set; }

        public void Show()
        {
            DependencyService.Get<IPhotoBrowser>().Show(this);
        }
    }
}
