using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GameObject go = Instantiate<GameObject>(Resources.Load<GameObject>("Prefabs/TestOne"));
        TestOne tt = go.GetComponent<TestOne>();
        if (tt == null)
        {
            tt = go.AddComponent<TestOne>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
