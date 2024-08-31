using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTexture : MonoBehaviour
{
    public MeshRenderer[] meshes;

    public void SetTextureOnAnimal(Texture2D texture)
    {
        foreach (var animal in meshes)
        {
            animal.material.mainTexture = texture;
        }
    }
}