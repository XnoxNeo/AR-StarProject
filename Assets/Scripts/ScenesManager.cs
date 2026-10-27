using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    
    
  public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
