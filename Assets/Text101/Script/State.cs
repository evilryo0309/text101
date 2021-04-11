using UnityEngine;

[CreateAssetMenu(menuName = "建立故事資料")]
public class State : ScriptableObject
{
    [SerializeField]
    [TextArea(10, 14)]
    string story;

    public State[] nextStorys;

    public string GetStory() => story;

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
