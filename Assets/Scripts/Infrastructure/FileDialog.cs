using System.Windows.Forms;

namespace Infrastructure
{
    //画像ファイル選択dialogを制御するクラス
    class ImgFileDialog
    {
        //画像ファイル選択dialogを開きファイルパスを返す関数
        public string OpenDialogAndGetFilePath()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "img files (*.jpg)|*.jpg|All files (*.*)|*.*";
            ofd.Title = "イメージファイルを選択してください";
            ofd.ShowDialog();

            string filePath = ofd.FileName;
            ofd.Dispose();
            return filePath;
        }
    }
}