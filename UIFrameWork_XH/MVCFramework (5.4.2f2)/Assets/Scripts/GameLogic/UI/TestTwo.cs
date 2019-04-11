using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestTwo : MonoBehaviour
{


    private Button btn;

    // Use this for initialization
    void Start()
    {
        btn = transform.Find("Panel/Button").GetComponent<Button>();
        btn.onClick.AddListener(OnClickBtn);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnClickBtn()
    {
        GameObject go = Instantiate<GameObject>(Resources.Load<GameObject>("Prefabs/TestOne"));
        TestOne tt = go.GetComponent<TestOne>();
        if ( tt==null)
        {
            tt = go.AddComponent<TestOne>();
        }
        Close();
    }

    private void Close()
    {
        Destroy(gameObject);
    }

}
