using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject unit;
    private GameObject clone;
    void Start()
    {
        clone = Instantiate(unit);

        clone.transform.position = new Vector3(0, 0, -5);
    }
}
