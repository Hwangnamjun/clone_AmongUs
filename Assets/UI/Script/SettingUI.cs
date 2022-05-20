using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{
    [SerializeField]
    private Button MouseButton;
    [SerializeField]
    private Button KeyMouseButton;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        switch(PlayerSettings.controlType)
        {
            case ControlType.Mouse:
                MouseButton.image.color = Color.green;
                KeyMouseButton.image.color = Color.white;
                break;
            case ControlType.KeyMouse:
                MouseButton.image.color = Color.white;
                KeyMouseButton.image.color = Color.green;
                break;
        }
    }

    public void setcontrolMode(int type)
    {
        PlayerSettings.controlType = (ControlType)type;

        switch (PlayerSettings.controlType)
        {
            case ControlType.Mouse:
                MouseButton.image.color = Color.green;
                KeyMouseButton.image.color = Color.white;
                break;
            case ControlType.KeyMouse:
                MouseButton.image.color = Color.white;
                KeyMouseButton.image.color = Color.green;
                break;
        }
    }

    public void Close()
    {
        StartCoroutine(closeDelay());
    }

    private IEnumerator closeDelay()
    {
        animator.SetTrigger("Close");
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
        animator.ResetTrigger("Close");
    }
}
