using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor.Events;
using Zenject;
public class UIPlayerMovement : MonoBehaviour
{
    [Inject] private IPlayerMovementService _playerMovementService;
    [SerializeField] private EventTrigger leftButton;
    EventTrigger.Entry entry = new EventTrigger.Entry();
    private void Start()
    {
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        leftButton.triggers.Add(entry);
    }
}
