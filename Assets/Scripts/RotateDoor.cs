using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDoor : MonoBehaviour
{
    public GameObject DoorCenterObject;
    public float duration = 1f;
    public Vector3 OriginalAngle;
    public Vector3 TargetAngle;

    private bool _lowerDoor = false;
    private Vector3 _raisedPosition;

    // Start is called before the first frame update
    void Start()
    {
        //_raisedPosition = DoorObject.transform.position;
    }

    public void ToggleDoorOpen()
    {
        StopAllCoroutines();
        if (!_lowerDoor)
        {
            //Vector3 lowerPosition = Angle;
            StartCoroutine(MoveDoor(TargetAngle));
        }
        else
        {
            StartCoroutine(MoveDoor(OriginalAngle));
        }

        _lowerDoor = !_lowerDoor;
    }

    IEnumerator MoveDoor(Vector3 targetAngle)
    {
        float timeElapsed = 0;
        Vector3 startAngle = DoorCenterObject.transform.eulerAngles;
        while (timeElapsed < duration)
        {
            DoorCenterObject.transform.eulerAngles = Vector3.Lerp(startAngle, targetAngle, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        DoorCenterObject.transform.eulerAngles = targetAngle;
    }
}
