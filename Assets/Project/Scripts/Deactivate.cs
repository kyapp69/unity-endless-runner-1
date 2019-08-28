﻿using UnityEngine;

namespace Project.Scripts
{
    public class Deactivate : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                // Make sure that the element is behind the camera enough
                // to not see it de-spawning.
                // TODO: The T-section is rather long - we need to ensure we actually left it before de-spawning.
                Invoke(nameof(SetInactive), 3.0f);
            }
        }

        private void SetInactive()
        {
            gameObject.SetActive(false);
        }
    }
}
