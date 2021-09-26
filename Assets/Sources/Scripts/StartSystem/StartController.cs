using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(1);
        }
    }
}
