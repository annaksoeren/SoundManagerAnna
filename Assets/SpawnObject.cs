using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private GameObject dog;

    public void SpawnButton()
    {
        Instantiate(dog, this.transform);
    }
}
