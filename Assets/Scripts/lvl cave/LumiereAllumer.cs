using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LumiereAllumer : MonoBehaviour
{
    public ComputeShader ShaderBg;
    public RenderTexture RT;
    public float TailleDuRond = 1;
    public float multiplicateur = 0.005f;
    public float Puissance = 1;

    public Vector2 PositionCercle2;
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (RT == null || RT.height != Screen.height || RT.width != Screen.width) 
        {
            RT = new RenderTexture(Screen.width, Screen.height, 24);
        RT.enableRandomWrite = true;
        RT.Create();
        }

        ShaderBg.SetVector("PositionDeLaSouris", Input.mousePosition);
        ShaderBg.SetTexture(0, "Input", src);
        ShaderBg.SetTexture(0, "Result", RT);
        ShaderBg.SetFloat("ratio", 1080f/(float)Screen.height);

        ShaderBg.SetFloat("TailleDuCercle", TailleDuRond);
        ShaderBg.SetFloat("multiplicateur", multiplicateur);
        ShaderBg.SetFloat("Puissance", Puissance); 

        ShaderBg.SetVector("PositionCercle2", PositionCercle2);

        ShaderBg.Dispatch(0, RT.width/8, RT.height/8, 1);
        
        // Read pixels from the source RenderTexture, apply the material, copy the updated results to the destination RenderTexture
        Graphics.Blit(RT, dest);
        //Debug.Log("Baise ta mere");
    }
  
}
