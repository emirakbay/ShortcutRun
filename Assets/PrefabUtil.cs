using UnityEngine;

public class PrefabUtil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var child = GetComponent<Transform>().GetChild(2);

        Debug.Log(child);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
