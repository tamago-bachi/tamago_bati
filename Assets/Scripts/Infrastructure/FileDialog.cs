using SFB;

namespace Infrastructure
{
    //画像ファイル選択dialogを制御するクラス
    class ImgFileDialog
    {
        //画像ファイル選択dialogを開きファイルパスを返す関数
        public string OpenDialogAndGetFilePath()
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