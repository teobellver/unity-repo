using Cinemachine;
using UnityEngine;
[RequireComponent(typeof(CinemachineVirtualCamera))]
public class camara_movement : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    private void Awake(){
        
        Camera.main.gameObject.TryGetComponent<CinemachineBrain>(out var brain);
        //si no hay brain/controlador, crear uno
        if (brain == null) {Camera.main.gameObject.AddComponent<CinemachineBrain>();
        }
    }
}
