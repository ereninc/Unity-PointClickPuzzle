using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class BackgroundColorMaker : ObjectModel
{
    [SerializeField] Gradient bgColor;
    Texture2D createdTex;

    [EditorButton]
    public void LoadColorToRenderer(Renderer mainRenderer)
    {
        createdTex = new Texture2D(1, bgColor.colorKeys.Length);
        createdTex.wrapMode = TextureWrapMode.Clamp;
        Color[] colors = new Color[bgColor.colorKeys.Length];
        for (int i = 0; i < bgColor.colorKeys.Length; i++)
        {
            colors[i] = bgColor.colorKeys[i].color;
        }

        createdTex.SetPixels(colors);
        createdTex.Apply();

        mainRenderer.sharedMaterial.mainTexture = createdTex;
    }

    [EditorButton]
    public void LoadColorToImage(Image img)
    {
        createdTex = new Texture2D(1, bgColor.colorKeys.Length);
        createdTex.wrapMode = TextureWrapMode.Clamp;
        Color[] colors = new Color[bgColor.colorKeys.Length];
        for (int i = 0; i < bgColor.colorKeys.Length; i++)
        {
            colors[i] = bgColor.colorKeys[i].color;
        }

        createdTex.SetPixels(colors);
        createdTex.Apply();

        Sprite sprite = Sprite.Create(createdTex, new Rect(0, 0, createdTex.width, createdTex.height), Vector2.one * 0.5f);
        img.sprite = sprite;
    }

    [EditorButton]
    public void ExportToPNG()
    {
#if UNITY_EDITOR
        createdTex = new Texture2D(1, bgColor.colorKeys.Length);
        createdTex.wrapMode = TextureWrapMode.Clamp;
        Color[] colors = new Color[bgColor.colorKeys.Length];
        for (int i = 0; i < bgColor.colorKeys.Length; i++)
        {
            colors[i] = bgColor.colorKeys[i].color;
        }

        createdTex.SetPixels(colors);
        createdTex.Apply();

        string path = EditorUtility.SaveFilePanel("Save Sprite", Application.dataPath, "", "png");

        if (path.Length > 0)
        {
            System.IO.File.WriteAllBytes(path, createdTex.EncodeToPNG());
        }
            AssetDatabase.Refresh();
#endif
    }
}
