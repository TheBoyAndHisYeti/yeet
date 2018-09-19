using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item
{
    private int use;

    public int maxUses;
    public string usetext;

    public void Start()
    {
        use = maxUses;
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log(ToString());
        use--;
    }

    public virtual void Use()
    {

    }

    public override string ToString()
    {
        return displayName + " has " + use + " out of " + maxUses + "uses";
    }


}
