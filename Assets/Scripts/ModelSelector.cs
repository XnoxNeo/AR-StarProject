using NUnit.Framework;
using UnityEngine;

public class ModelSelector : MonoBehaviour
{
   public GameObject[] gameObjects;
    public int currentGameObejct = 0;
  


    private void Start()
    {
        foreach (var gameObject in gameObjects)
        {
            gameObject.SetActive(false);
        }
    }

    public void Update()
    {
        
    }
    public void ChangeObject()
    {
        currentGameObejct++;
        if(currentGameObejct == gameObjects.Length)
        {
            currentGameObejct = 0;
        }

        foreach (var gameObject in gameObjects)
        {
            gameObject.SetActive(false);
        }

        gameObjects[currentGameObejct].SetActive(true);
        var renderer = gameObjects[currentGameObejct].GetComponent<MeshRenderer>();
        renderer.enabled = true;
    



        }
        
}


