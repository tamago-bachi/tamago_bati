using System;
using Infrastructure;
using UnityEngine;

namespace Demo
{
    public class DemoImgFileDialog : MonoBehaviour
    {
        void Start()
        {
            var filePath = new ImgFileDialog().OpenDialogAndGetFilePath();
            Debug.Log(filePath);
        }
    }
}