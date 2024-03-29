﻿using System.Collections;
using System.Collections.Generic;
using Infrastructure;
using Domain;
using UnityEngine;

public class God : MonoBehaviour
{
    [SerializeField] ImageSelectButton imageSelectButton;
    [SerializeField] FishGenerator fishGeneratorPrefab;
    [SerializeField] SeaObjectGenerator seaObjectGenerator;
    [SerializeField] ParticleGenerator particleGenerator;

    // Start is called before the first frame update
    void Start()
    {
        var fishGenerator = Instantiate(fishGeneratorPrefab);
        var developmentLevelManager = new DevelopmentLevelManager();
        imageSelectButton.clicked += () =>
        {
            var filePath = new ImgFileDialog().OpenDialogAndGetFilePath();

            //ToDo　ここでfilepathからランク判定して、魚の生成とスコア加算処理する
            var rank = new EggDishesRankChecker().EggDishImageToRank(filePath);
            fishGenerator.GenerateFish(rank);
            particleGenerator.GenerateParticle(rank);
            var score = new ScoreTransformer().GetScoreFromRank(rank);
            developmentLevelManager.AddScore(score);
        };
        developmentLevelManager.DevelopmentLevelChanged += developmentLevel =>
        {
            seaObjectGenerator.GenerateSeaObject(developmentLevel);
        };
    }
}