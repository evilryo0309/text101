using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AdvantureGame : MonoBehaviour
{
    public Text Story;

    [SerializeField]
    State state;

    IEnumerator Start()
    {
        return ReadStory();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
            state = state.nextStorys[0];
        else if (Input.GetKeyDown(KeyCode.Alpha1))
            state = state.nextStorys[1];
        else
            return;

        StartCoroutine(ReadStory());
    }

    IEnumerator ReadStory()
    {
        var text = state.GetStory();
        for (int i = 0; i < text.Length; i++)
        {
            Story.text = text.Substring(0, i);
            yield return null;
        }
    }
}
