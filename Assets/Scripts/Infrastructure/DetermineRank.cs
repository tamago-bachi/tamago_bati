using System;
using Domain;
using Google.Cloud.Vision.V1;
using UnityEngine;

namespace Infrastructure
{
    //ランクを判定するクラス
    class EggDishesRankChecker
    {
        //エンティティ上位から順にEggWordListにあるwordがあるか判定し、ランクを返す関数
        public EggRank EggDishImageToRank(string imagepath)
        {
            EggWordList eggWordList = new EggWordList();
            
            
            string value = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
            if (value == null)
            {
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIAL","/Users/tetsu/Desktop/ITCTrainingCanp2019/tamago-bachi-78a51a504aa0.json");
            }
            var client = ImageAnnotatorClient.Create();
            // Load the image file into memory
            var image = Image.FromFile(imagepath);
            // Performs label detection on the image file
            var response = client.DetectWebInformation(image);
            foreach (var annotation in response.WebEntities)
            {
                string entity = annotation.Description;
                EggRank rank = eggWordList.GetEggRank(entity);
                if (rank != EggRank.Nothing)
                {
                    return rank;
                }
            }
            return EggRank.Nothing;
        }
    }
}