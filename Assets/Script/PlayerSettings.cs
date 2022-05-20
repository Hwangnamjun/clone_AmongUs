using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ControlType
{
    Mouse,
    KeyMouse
}


public class PlayerSettings : MonoBehaviour
{
    public static ControlType controlType;
}
