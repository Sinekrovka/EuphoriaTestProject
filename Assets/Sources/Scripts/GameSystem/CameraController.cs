using Kuhpik;
using UnityEngine;

public class CameraController : GameSystem, IIniting
{
    [SerializeField] private GameObject loadingCamera;

    [SerializeField] private GameObject firstPersonCamera;
    [SerializeField] private GameObject thirdPersonCamera;
    
    void IIniting.OnInit()
    {
        loadingCamera.SetActive(false);
        firstPersonCamera.SetActive(true);
        FindObjectOfType<InputSystem>().ChangeCameraEvent += ChangeCamera;
    }

    private void ChangeCamera(string x)
    {
        firstPersonCamera.SetActive(!firstPersonCamera.activeSelf);
        thirdPersonCamera.SetActive(!thirdPersonCamera.activeSelf);
    }
}
