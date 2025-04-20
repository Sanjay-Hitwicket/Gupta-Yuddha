using UnityEngine;
using UnityEngine.InputSystem;

namespace InputControls
{
    public class GestureView : MonoBehaviour
    {
        [SerializeField] private InputAction touchAction;

        private void OnEnable()
        {
            touchAction.Enable();
        }

        private void OnDisable()
        {
            touchAction.Disable();
        }

        private void Update()
        {
            if (touchAction != null) {
                if (touchAction.WasPressedThisFrame()) // Equivalent to Input.GetKeyDown()
                {
                    Debug.Log("Touch Started");
                }
            }
            else
            {
                Debug.LogError("Touch Action is not assigned! Assign it in the Inspector.");
            }
        }

    }
}
