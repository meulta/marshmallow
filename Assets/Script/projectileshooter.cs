using UnityEngine;
using System.Collections;
using UnityEngine.XR.WSA.Input;
using HoloToolkit.Unity.InputModule;

public class projectileshooter : MonoBehaviour
{
    GameObject prefab;

    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;

        InteractionManager.InteractionSourcePressed += InteractionSourcePressed;
    }

    private void InteractionSourcePressed(InteractionSourcePressedEventArgs obj)
    {
        if (obj.pressType == InteractionSourcePressType.Select)
        {
            Vector3 direction;
            Vector3 startposition;

            obj.state.sourcePose.TryGetForward(out direction);
            obj.state.sourcePose.TryGetPosition(out startposition);
           
            GameObject projectile = Instantiate(prefab, transform.parent.parent) as GameObject;
            projectile.transform.localPosition = startposition;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = direction * 40;
        }
    }
}