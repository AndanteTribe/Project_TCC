using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.TinyCharacterController.Settings
{
#if PACKAGE_VISUAL_SCRIPTING
    [Unity.VisualScripting.RenamedFrom("TinyCharacterController.Settings.CameraUserSettings")]
#endif
    [CreateAssetMenu(menuName = "TCC/CameraUserSettings", fileName = "New TCC Camera Setting", order = 100)]
    public class CameraUserSettings : ScriptableObject
    {
        [Range(0.1f, 1000f)]
        public float MouseSensitivity = 50;
        public bool InverseX = false;
        public bool InverseY = false;
    }
}
