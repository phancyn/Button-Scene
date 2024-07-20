using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public int sceneid
    
    public void loadScene()
    {
        SceneManager.LoadScene(sceneid);
    }
}
