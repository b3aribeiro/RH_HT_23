using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneReset : MonoBehaviour
{

    public InputActionReference toggleReference = null;
    
    /*secondaryButton [LeftHand XR Controller] = Y button
    primaryButton [LeftHand XR Controller] = X button
    secondaryButton [RightHand XR Controller] = B button
    primaryButton [RightHand XR Controller] = A button*/
    
      private void Awake()
    {
        toggleReference.action.started += ResetScene;
    }

    private void OnDestroy()
    {
        toggleReference.action.started += ResetScene;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    private void ResetScene(InputAction.CallbackContext context)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
