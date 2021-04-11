// create and access the ScriptObj

using UnityEngine;

public class ScriptObjExample : MonoBehaviour
{
    ScriptObj test;

    void Start()
    {
        test = (ScriptObj)ScriptableObject.CreateInstance(typeof(ScriptObj));

        print(test.A);
        print(test.B(3));
        print(test.B(-3));
    }
}