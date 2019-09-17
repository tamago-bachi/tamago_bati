using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using UnityEngine;

public class God : MonoBehaviour
{
    [SerializeField] ImageSelectButton imageSelectButton;

    // Start is called before the first frame update
    void Start()
    {
        imageSelectButton.clicked += () =>
        {
            var filePath = new ImgFileDialog().OpenDialogAndGetFilePath();
            Debug.Log(filePath);
            //ToDo　ここでfilepathからランク判定して、魚の生成とスコア加算処理する
        };
    }
}