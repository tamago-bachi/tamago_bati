using SFB;
using UnityEngine;

namespace Infrastructure
    {
        public class OtherImgFileDialog
        {
            public string OpenDialogAndGetFilePath2()
            {
                var extensions = new [] {
                    new ExtensionFilter("Image Files", "png", "jpg", "jpeg" ),
                    new ExtensionFilter("All Files", "*" ),
                };
                var paths = StandaloneFileBrowser.OpenFilePanel("Open File", "", extensions, true);
                return paths[0];
            }
        }
    }