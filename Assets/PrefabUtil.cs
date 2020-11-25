using UnityEngine;
using System.Collections.Generic;

public class PrefabUtil : MonoBehaviour
{
    public GameObject blockPrefab;

    public Transform robotTransform;


    public Stack<GameObject> stack;
    [Header("Stack Position Values")]
    public Vector3 stackStartPos;
    public Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        BuildStack();
    }


    private void BuildStack()
    {
        GameObject blockObject = Instantiate(blockPrefab, new Vector3(0, 0, 0), Quaternion.identity, robotTransform);
    }
}
