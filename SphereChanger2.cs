using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SphereChanger : MonoBehaviour
{
    public float movementDuration;
    [SerializeField] Slider volumeSlider;

    public void ChangeSphere(Transform nextSphere)
    {
        StartCoroutine(MoveToPosition(nextSphere.position));
    }

    /*public override void OnWaitDone()
    {
    }*/

    public void ChangeCanvas(Transform canvas)
    {
        StartCoroutine(MoveToCanvas(canvas.position));
    }

    public IEnumerator MoveToPosition(Vector3 position)
    {
        float elapsedTime = 0;
        Vector3 initialPosition = transform.position;

        while (elapsedTime < movementDuration)
        {
            yield return new WaitForEndOfFrame();
            elapsedTime += Time.deltaTime;

            transform.position = Vector3.Lerp(initialPosition, position, elapsedTime / movementDuration);
        }
        transform.position = position;
    }

    public IEnumerator MoveToCanvas(Vector3 position)
    {
        float elapsedTime = 0;
        Vector3 initialPosition = transform.position;

        while (elapsedTime < movementDuration)
        {
            yield return new WaitForEndOfFrame();
            elapsedTime += Time.deltaTime;

            transform.position = Vector3.Lerp(initialPosition, position, elapsedTime / movementDuration);
        }
        transform.position = position;
    }

    public void ChangeSpeed()
    {
        movementDuration = volumeSlider.value;
    }
}

