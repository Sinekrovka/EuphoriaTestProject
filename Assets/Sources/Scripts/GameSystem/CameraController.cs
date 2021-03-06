using Kuhpik;
using UnityEngine;

public class CameraController : GameSystem, IIniting
{
    [SerializeField] private GameObject firstPersonCamera;
    [SerializeField] private GameObject thirdPersonCamera;
    
    void IIniting.OnInit()
    {
        firstPersonCamera.SetActive(true);
        firstPersonCamera.GetComponent<Camera>().fieldOfView = 65;
        game.fpc.enabled = true;
        FindObjectOfType<InputSystem>().ChangeCameraEvent += ChangeCamera;
    }

    private void ChangeCamera(string x)
    {
       /* firstPersonCamera.SetActive(!firstPersonCamera.activeSelf);
        thirdPersonCamera.SetActive(!thirdPersonCamera.activeSelf);*/
    }
}
