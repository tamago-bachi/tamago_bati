using Infrastructure;
using UnityEngine;

namespace Demo
{
    public class DemoOtherFileDialog : MonoBehaviour
    {
        void Start()
        {
           string path =  new OtherImgFileDialog().OpenDialogAndGetFilePath2();
           Debug.Log(path);
        }
    }
}