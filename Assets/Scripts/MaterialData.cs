using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialData : MonoBehaviour
{
    public string[] materialTitle;
    public string[] materialDesc;
    [TextArea(50, 255)]
    public string[] materialPoint;
    public string[] materialTitleID;
    public string[] materialDescID;
    [TextArea(50, 255)]
    public string[] materialPointID;
}
