using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.StateChanged += HandleStateChange;
    }

    private void OnDisable()
    {
        GameManager.StateChanged -= HandleStateChange;
    }

    private void HandleStateChange()
    {
        string state = GameManager.GetState();
        Debug.Log("State Changed: " + state);
    }
}
