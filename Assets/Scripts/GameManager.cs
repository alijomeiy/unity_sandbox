using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Action StateChanged;
    private static string _state;

    public static void ChangeState(string state)
    {
        _state = state;
        StateChanged?.Invoke();
    }

    public static string GetState()
    {
        return _state;
    }
}
