using System;
using Google.Cloud.Vision.V1;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string value = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");

        Debug.Log(value);
        // Instantiates a client
        var client = ImageAnnotatorClient.Create();
        // Load the image file into memory
        var image = Image.FromFile("Assets/Imgs/egg.jpg");
        // Performs label detection on the image file
        var response = client.DetectWebInformation(image);
        foreach (var annotation in response.WebEntities)
        {
            Debug.Log(annotation.Description);
            Debug.Log(annotation.Score);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}