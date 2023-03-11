// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

using UnityEngine;

// Do not remove base class as it is needed for modkit
public partial class HighlightableObject : MonoBehaviour
{
    public bool seeThrough;
    
    [Tooltip("Transparent generic highlight material of mesh bonds will be used if this is ON (instead of mesh highlight)")]
    public bool forceOpaque;
}
