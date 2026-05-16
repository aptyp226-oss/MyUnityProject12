using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using static GameEnums;

public class ButtonController : MonoBehaviour
{
    [SerializeField] protected ESoundName _sfxName;

    public virtual void OnClick()
    {
        SoundsManager.Instance.PlaySfx(_sfxName, 1.0f);
        UnityEngine.Debug.Log("play " + _sfxName);

        if (EventSystem.current != null)
        {
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}