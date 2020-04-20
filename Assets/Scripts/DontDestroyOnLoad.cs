﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This object won't be destroyed when a new scene is loaded
//
//=============================================================================

using UnityEngine;
using System.Collections;

public class DontDestroyOnLoad : MonoBehaviour
{
	//-------------------------------------------------
	void Awake()
	{
		DontDestroyOnLoad( this );
	}
}
