using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Points = 0;

    public static GameManager instance = null;

    private void Awake()
    {
        instance = this;
    }
}
