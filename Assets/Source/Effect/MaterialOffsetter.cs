using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialOffsetter : MonoBehaviour
{
    public Material Material;
    public Vector2 Speed;
    public bool IsActive;
    Vector2 value;

    private void Update()
    {
        if (IsActive)
        {
            value += Speed * Time.deltaTime;
            Material.SetTextureOffset("_BaseMap", value);
        }
    }

}
