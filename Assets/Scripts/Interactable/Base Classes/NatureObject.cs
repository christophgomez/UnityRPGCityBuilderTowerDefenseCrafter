﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NatureObject : DestructableObject
{

	// Start is called before the first frame update
	public override void Start()
  {
		base.Start();
	}

  // Update is called once per frame
  public override void Update()
  {
		base.Update();
	}

	public override void TakeDamage(int damage, Tool.ToolType t)
	{
		base.TakeDamage(damage, t);
		gameManager.DeregisterGridObject(gameObject);
	}
}
